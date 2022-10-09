using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace DataEntryApp
{
    public class RMESForm : Form
    {
        // All forms get these
        public String date = DateTime.Today.ToString();
        public System.Version _version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
        public Color _originalControlBackColor;
        public Color _warningColor = Color.Yellow;
        public string _parentSavePath;

        //Extra Controls Added During Runtime
        protected List<Control> _extraControls = new List<Control>();   
        protected string _extraControlNameSuffix = "EWO_";
        protected Label _genericPreviousDataWarning = new Label();

        protected Button _btnBack;
        protected Button _btnForward;
        protected Button _btnSubmit;

        protected Panel _sidePanel;

        public Action _buildFormData;

        protected enum outputModes
        {
            csv, mysql
        }

        protected outputModes _outputMode = outputModes.csv;
        protected List<Control> _editableControls = new List<Control>();
        protected List<Control> _dataWarningControls = new List<Control>();

        public TextBox _txtExtractionWorkOrder;
        public Button _btnNextWorkOrder;

        public bool _debug = false;

        protected CsvManager _csvManager;
        protected ProcessManager _pm = new ProcessManager();

        protected FormData _formData;

        protected string _csvFileName;
        protected string _pathToCsv;
        /*
        static List<string> _reactorJobs = File.ReadAllText("O://Production/MES/ReactorInitials.csv").Replace(" ", "").Split(',').ToList();
        static List<string> _200LJobs = File.ReadAllText("O://Production/MES/_200LInitials.csv").Replace(" ", "").Split(',').ToList();
        static List<string> _40LJobs = File.ReadAllText("O://Production/MES/_40LInitials.csv").Replace(" ", "").Split(',').ToList();
        static List<string> _CustomerOrderJobs = File.ReadAllText("O://Production/MES/CustomerOrderInitials.csv").Replace(" ", "").Split(',').ToList();
        static List<string> _MillJobs = File.ReadAllText("O://Production/MES/MillingInitials.csv").Replace(" ", "").Split(',').ToList();
        static List<string> _PasteurJobs = File.ReadAllText("O://Production/MES/PasteurInitials.csv").Replace(" ", "").Split(',').ToList();
        static List<string> _DecarbJobs = File.ReadAllText("O://Production/MES/DecarbInitials.csv").Replace(" ", "").Split(',').ToList();
        static List<string> _DistillationJobs = File.ReadAllText("O://Production/MES/DistillationInitials.csv").Replace(" ", "").Split(',').ToList(); */
        protected enum jobs
        {
            Reactor,
            Decarb,
            Distillation,
            Mill,
            L200,
            L40,
            CustomerOrders,
            Pasteur
        }

        Dictionary<jobs, List<string>> _workersByJob = new Dictionary<jobs, List<string>>
        {
            /*{jobs.Reactor, _reactorJobs }, 
            {jobs.L200, _200LJobs },
            {jobs.L40, _40LJobs },
            {jobs.CustomerOrders, _CustomerOrderJobs },
            {jobs.Mill, _MillJobs },
            {jobs.Pasteur, _PasteurJobs},
            {jobs.Decarb, _DecarbJobs },
            {jobs.Distillation, _DistillationJobs }
            */

            {jobs.Reactor, new List<string> {"JE", "KC", "ZB", "BD", "JC", "Rich", "MM", "RL" } },
            {jobs.L200, new List<string> {"JE", "KC", "ZB", "BD", "JC", "Rich", "MM", "RL" }  },
            {jobs.L40, new List<string> {"JE", "KC", "ZB", "BD", "JC", "Rich", "MM", "RL" }  },
            {jobs.CustomerOrders, new List<string> {"JE", "KC", "ZB", "BD", "JC", "Rich", "MM", "RL" }  },
            {jobs.Mill, new List<string> {"JE", "KC", "ZB", "BD", "JC", "Rich", "MM", "RL" }  },
            {jobs.Pasteur, new List<string> {"JE", "KC", "ZB", "BD", "JC", "Rich", "MM", "RL" } },
            {jobs.Decarb, new List<string> {"JE", "KC", "ZB", "BD", "JC", "Rich", "MM", "RL" } },
            {jobs.Distillation, new List<string> {"JE", "KC", "ZB", "BD", "JC", "Rich", "MM", "RL" }  }
        };


        protected jobs _thisJob;
        protected ComboBox _cmbOperator;
        protected List<string> _operatorNames = new List<string>();

        protected void PerformGeneralSetup(RMESForm sender)
        {
            if (_outputMode == outputModes.csv)
            {
                _pathToCsv = GetCsvFilePath();
                _csvManager = new CsvManager();
                _csvManager.CreateCsv(_pathToCsv);
                _formData.SetCsvPagesData(_pathToCsv);
            }
            // Delegates / Actions
            _buildFormData = BuildFormData;
            _formData._addNewTextBox = AddExtraWorkOrderTextBoxes;
            _sidePanel.Height = Screen.PrimaryScreen.WorkingArea.Height;

            AddAllListeners();
            if(sender._cmbOperator.Items.Count == 0)
                SetupOperatorNames();
            BuildFormData();
            SetFormInitialValues();
            MapEditableControls();
            MapDataWarningControls();
            RefreshNavigationArrows();

        }

        protected virtual void BuildFormData() { }

        private void SetupOperatorNames()
        {
            _workersByJob[_thisJob].ForEach(j => _cmbOperator.Items.Add(j));
            _cmbOperator.SelectedIndex = 0;
        }

        protected void AddExtraControlToFormData(TextBox tb)
        {
            Label lblExtraWO = new Label();
            string fullName = _extraControlNameSuffix + (_extraControls.Count()).ToString();
            tb.Name = fullName;
            lblExtraWO.Name = fullName;
            FormDataGroup group = new FormDataGroup(lblExtraWO, tb, tb.Text);
            _formData.AddFormDataGroup(group, true); // true means we're adding to extra controls list
            
        }

        protected void RefreshNavigationArrows()
        {
            if (File.Exists(_pathToCsv) && File.ReadAllLines(_pathToCsv).Count() > 1)
                _formData.SetCsvPagesData(_pathToCsv);
            _btnBack.Visible = 
                _formData._currentPage < _formData.NumberOfDataPages - 1;
            _btnForward.Visible = _formData.CurrentPage >= 0;
        }

        private List<Control> GetControlsToShift(Control highestControl)
        {
            List<Control> targetControls = new List<Control>();
            foreach (Control control in this.Controls)
            {
                if (control.Location.Y > highestControl.Location.Y)
                {
                    targetControls.Add(control);
                }
            }
            return targetControls;
        }

        public void AddExtraWorkOrderTextBoxes(TextBox txtModel, Button btnToShift, string value = "")
        {
            // Shift Controls Location Logic
            int yShiftAmount = txtModel.Height + 10;
            List<Control> controlsToShift = GetControlsToShift(btnToShift);
            TextBox textBox = new TextBox();
            textBox.Size = txtModel.Size;
            textBox.Font = txtModel.Font;
            textBox.Text = value == "" ? $"EX." : value;
            this.Controls.Add(textBox);
            _extraControls.Add(textBox);
            AddExtraControlToFormData(textBox);
            int timesToShift = _extraControls.Count();
            int txtX = txtModel.Location.X;
            int txtY = txtModel.Location.Y + yShiftAmount * timesToShift;
            int btnX = btnToShift.Location.X;
            int btnY = btnToShift.Location.Y + yShiftAmount;

            // Shift control locations
            Point btnPos = new Point(btnX, btnY);
            btnToShift.Location = btnPos;

            Point txtBoxPos = new Point(txtX, txtY);
            textBox.Location = txtBoxPos;

            this._sidePanel.Height += yShiftAmount;

            controlsToShift.ForEach(c => c.Location = new Point(c.Location.X, c.Location.Y + yShiftAmount));

        }

        protected void RemoveExtraTextBoxes(TextBox txtModel, Button btnNextWO)
        {
            _formData._extraFormData.Clear();
            int yShiftAmount = txtModel.Height + 10;
            List<Control> controlsToShift = GetControlsToShift(btnNextWO);
            int timesToShift = 0;
            controlsToShift.Add(btnNextWO); // TODO: for some reason we have to explicity add here; debug and fix later
            List<Control> tempList = _extraControls.ToList();
            foreach (Control c in tempList)
            {
                this.Controls.Remove(c);
                _extraControls.Remove(c);
                timesToShift += 1;
            }
            _buildFormData();
            yShiftAmount *= (-1 * timesToShift);
            this._sidePanel.Height += yShiftAmount;

            controlsToShift.ForEach(c => c.Location = new Point(c.Location.X, c.Location.Y + yShiftAmount));

        }

        private void MapEditableControls()
        {
            _editableControls.Clear();
            foreach (Control c in this.Controls)
            {
                if (!(c is Label) && !(c is Panel) && !(c is Button) /*&& !(c is ComboBox)*/)
                {
                    _editableControls.Add(c);
                }
                if (c is Panel)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (!(c2 is Label))
                            _editableControls.Add(c2);
                    }
                }
            }
        }

        private void MapDataWarningControls()
        {
            _dataWarningControls.Clear();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is NumericUpDown)
                {
                    _dataWarningControls.Add(c);
                }
                if (c is Panel)
                {
                    foreach (Control c2 in c.Controls)
                    {
                        if (!(c2 is ComboBox) && !(c2 is Label) && !(c2 is PictureBox) && !(c2 is Button) && !(c2 is PictureBox))
                            _dataWarningControls.Add(c2);
                    }
                }
            }
        }

        protected void ToggleControlWarningColor(bool set, Control c)
        {
            c.BackColor = set ? _warningColor : _originalControlBackColor;
        }

        protected bool AreFieldsEmpty(Form form)
        {
            int count = 0;
            bool validData = false;
            foreach (Control control in form.Controls)
            {
                if (string.IsNullOrWhiteSpace(control.Text) && !(control is Label) && !(control is Panel) && !(control.Name.Contains("Comment")))
                {
                    count++;
                }

                if (control is NumericUpDown)
                {
                    NumericUpDown nud = control as NumericUpDown;
                    if (nud.Value == 0)
                    {
                        count++;
                    }
                }
                if (control is Panel)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        if (control2 is TextBox)
                        {
                            TextBox textbox = control2 as TextBox;
                            if (string.IsNullOrWhiteSpace(textbox.Text) && !(textbox.Name.Contains("Comment")))
                            {
                                count++;
                            }
                        }
                        if (control2 is NumericUpDown)
                        {
                            NumericUpDown nud = control2 as NumericUpDown;
                            if (nud.Value == 0)
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            if (count > 0)
            {
                validData = true;
            }
            else
                validData = false;
            return validData;
        }

        protected string FieldsThatAreEmpty(Form form)
        {
            string fields = "";
            foreach (Control control in form.Controls)
            {

                if (string.IsNullOrWhiteSpace(control.Text) && !(control is Label) && !(control is Panel) && !(control.Name.Contains("Comment")))
                {
                    fields += control.Name.Substring(3) + " is empty \n";
                }

                if (control is NumericUpDown)
                {
                    NumericUpDown nud = control as NumericUpDown;
                    if (nud.Value == 0)
                    {
                        fields += nud.Name.Substring(3) + " is set to 0 \n";
                    }
                }
                if (control is Panel)
                {
                    foreach (Control control2 in control.Controls)
                    {
                        if (control2 is TextBox)
                        {
                            TextBox textbox = control2 as TextBox;
                            if (string.IsNullOrWhiteSpace(textbox.Text) && !(textbox.Name.Contains("Comment")))
                            {
                                fields += textbox.Name.Substring(3) + " is empty \n";

                            }
                        }
                        if (control2 is NumericUpDown)
                        {
                            NumericUpDown nud = control2 as NumericUpDown;
                            if (nud.Value == 0)
                            {
                                fields += nud.Name.Substring(3) + " is set to 0 \n";
                            }
                        }
                    }
                }
            }
            return fields;
        }

        protected void TogglePreviousDataWarning(bool show, Label label)
        {
            label.BackColor = _warningColor;
            label.Visible = show;
        }

        protected bool ColorCheck(List<Control> controls)
        {
            int count = 0;
            foreach (Control control in controls)
            {
                if (control.BackColor == _warningColor)
                    count++;
            }

            return count == 0;
        }

        protected List<string> GetFullListOfWorkers()
        {
            return _workersByJob.SelectMany(job => job.Value).ToList();
        }

        protected void SetControlValue(Control targetControl, string value)
        {
            if (targetControl is TextBox)
            {
                TextBox tb = targetControl as TextBox;
                targetControl.Text = value as string;
            }
            if (targetControl is DateTimePicker)
            {
                DateTimePicker dtp = targetControl as DateTimePicker;
                dtp.Value = DateTime.Parse(value);
            }
            if (targetControl is NumericUpDown)
            {
                NumericUpDown nud = targetControl as NumericUpDown;
                nud.Value = Int32.Parse(value);
            }
        }

        private void SetFormInitialValues()
        {
            if (_formData.CheckPreviousDataExists(GetCsvFilePath()))
            {
                _formData.GenerateFormDataFromCsv(_pathToCsv);
            }
            else
            {
                foreach (var control in _editableControls)
                {
                    if (control is TextBox)
                        SetControlValue(control, "");
                    if (control is DateTimePicker)
                    {
                        DateTimePicker dtp = control as DateTimePicker;
                        dtp.Value = DateTime.Now;
                    }
                }
                ActiveForm.Controls.OfType<NumericUpDown>().ToList().ForEach(nud => nud.Value = 0);
            }
        }

        protected string GetCsvFilePath()
        {
            return Directory.Exists(@"O:/Production/") ?
                Path.Combine(@"O:/Production/MES/", _csvFileName) :
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), _csvFileName);
        }

        protected void TogglePreviousDataWarnings(bool set)
        {
            List<Control> controlsToToggle = new List<Control>();
            controlsToToggle.AddRange(_dataWarningControls);
            controlsToToggle.AddRange(_extraControls);
            foreach (Control c in controlsToToggle)
                ToggleControlWarningColor(set, c);
            if (!_genericPreviousDataWarning.Visible)
            {
                _genericPreviousDataWarning.Visible = true;
                _genericPreviousDataWarning.BackColor = GetDataWarningColor();
            }
        }

        protected Color GetDataWarningColor()
        {
            return Color.Yellow;
        }

        protected void ToNextOlderEntry() // Back btn
        {
            TogglePreviousDataWarnings(false);
            _genericPreviousDataWarning.Visible = false; // Not a huge fan of this implementation - fix!
            if (_formData.CurrentPage == -1)
            {
                _formData.CacheFormData();
                var test = _formData._cachedFormData;
            }
            //_formData.ClearAllFormData();
            if (_extraControls.Count() > 0)
                RemoveExtraTextBoxes(_txtExtractionWorkOrder, _btnNextWorkOrder);
            _formData._currentPage += 1;

            _formData.GenerateFormDataFromCsv(_pathToCsv);
            RefreshNavigationArrows();
        }

        protected void ToNextMostRecentEntry() // Forward btn 
        {
            TogglePreviousDataWarnings(false);
            _genericPreviousDataWarning.Visible = false; // Not a huge fan of this implementation - fix!
            if (_extraControls.Count() > 0)
                RemoveExtraTextBoxes(_txtExtractionWorkOrder, _btnNextWorkOrder);
            if (_formData.CurrentPage > 0)
            {
                _formData._currentPage -= 1;
                _formData.GenerateFormDataFromCsv(_pathToCsv);
            }
            else
            {
                _formData._currentPage -= 1;

                _formData.SetFormDataToCachedData();
                _formData.RenderToFormFromData();
                _formData.RefreshFormData();
            }
            RefreshNavigationArrows();
        }

        protected virtual void SetFormDefaults() { }

        protected void SetFormSizeandPosition (Form form)
        {
            form.Size = Screen.PrimaryScreen.WorkingArea.Size;
            form.WindowState = FormWindowState.Normal;
            form.Bounds = new Rectangle(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Top - 100, Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            form.Location = new Point(0, 0);
            form.TopMost = false;
        }

        protected void SubmitData()
        {
            if (AreFieldsEmpty(this) == false)
            {
                if (_outputMode == outputModes.csv)
                {
                    bool isNewData = _formData.CurrentPage < 0;
                    _formData.RefreshFormData();
                    MessageBox.Show("Data Submitted");

                    AddWarningEventListeners();
                    TogglePreviousDataWarnings(true);
                    if (isNewData)
                    {
                        _formData.AppendFormDataToCsv(_pathToCsv);
                        if (_extraControls.Count() > 0)
                            RemoveExtraTextBoxes(_txtExtractionWorkOrder, _btnNextWorkOrder);
                    }

                    else
                    {
                        _formData.EditAndSaveToCsv(_pathToCsv);
                        // refresh the page to reflect what's in the updated csv chunk
                    }

                }

                else
                {
                    MessageBox.Show("No output mode selected");
                }
                RefreshNavigationArrows();
            }
            else
            {
                MessageBox.Show(FieldsThatAreEmpty(this));
            }
        }

        #region Events
        protected void AddAllListeners()
        {
            AddClickEventListeners();
            AddWarningEventListeners();
            AddStripCommaListeners();
        }

        private void AddClickEventListeners()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is NumericUpDown)
                    c.Click += new EventHandler(GenericControl_Click);
            }
        }

        private void AddWarningEventListeners()
        {
            foreach (Control c in _dataWarningControls)
            {
                if (!(c is Button) && !(c is Panel))
                {
                    c.Click += new EventHandler(GenericControl_Exit);
                    c.Leave += new EventHandler(GenericControl_Exit);
                }
            }
            // don't forget the controls that get added after the fact
            foreach (Control c in _extraControls)
            {
                if (c is TextBox)
                {
                    c.Click += new EventHandler(GenericControl_Exit);
                    c.Leave += new EventHandler(GenericControl_Exit);
                }
            }
        }

        private void AddStripCommaListeners()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Leave += new EventHandler(GenericControl_RemoveCommas);
            }
        }

        #endregion

        #region Listeners

        protected void GenericControl_Click(object sender, EventArgs args)
        {
            Control c = sender as Control;
            ToggleControlWarningColor(false, c);
            if (ColorCheck(_dataWarningControls))
            {
                TogglePreviousDataWarning(false, _genericPreviousDataWarning);
            }
        }

        protected void GenericControl_Exit(object sender, EventArgs args)
        {
            Control c = sender as Control;
            ToggleControlWarningColor(false, c);
            bool warningColorsActive = ColorCheck(_dataWarningControls);
            if (!warningColorsActive)
            {
                _genericPreviousDataWarning.Visible = false;
                _btnSubmit.Enabled = true;
            }
        }

        protected void GenericControl_RemoveCommas(object sender, EventArgs args)
        {
            Control c = sender as Control;
            _formData.RemoveCommasFromData(c);
        }

        #endregion

    }

    #region Data Structures and Helper Classes
    //
    // ##################################
    // Data Structures and Helper Classes
    // ##################################
    //
    public class FormData
    {
        public List<FormDataGroup> _currentFormData = new List<FormDataGroup>();
        public List<FormDataGroup> _cachedFormData = new List<FormDataGroup>();
        public List<FormDataGroup> _extraFormData = new List<FormDataGroup>();

        public Action<TextBox, Button, string> _addNewTextBox;

        public int _currentPage = -1;
        private int _totalNoOfPages = 0;
        private RMESForm _parentForm;

        private string[] _csvChunks;

        public FormData(RMESForm parentForm)
        {
            _parentForm = parentForm;
        }

        public void ClearAllFormData(bool includeCache = false)
        {
            _currentFormData.ForEach(group => group._data = "");
            _extraFormData.Clear();
            if (includeCache)
                _cachedFormData.Clear();
        }

        public bool CheckPreviousDataExists(string pathToCsv)
        {
            return File.ReadLines(pathToCsv).Count() > 1;
        }

        public void AddFormDataGroup(FormDataGroup group, bool isExtraControl = false)
        {
            if (!isExtraControl)
                _currentFormData.Add(group);
            else
                _extraFormData.Add(group);
        }
        
        /// <summary>
        /// Returns total number of pages, starting at 1
        /// </summary>
        public int NumberOfDataPages
        {
            get { return _totalNoOfPages; }
        }

        public void SetCsvPagesData(string pathToCsv)
        {
            CsvManager csvm = new CsvManager();
            _csvChunks = csvm.GetCsvPages(pathToCsv);
            _totalNoOfPages = _csvChunks.Length;
        }

        public int CurrentPage
        {
            get { return _currentPage; }
        }

        public List<FormDataGroup> CurrentFormData
        {
            get { return _currentFormData; }
        }

        public void RemoveCommasFromData(Control targetControl)
        {
            TextBox tb = targetControl as TextBox;
            tb.Text = tb.Text.Replace(",", "");
            RefreshFormData();
        }

        public void GenerateFormDataFromCsv(string pathToCsv)
        {
            ClearAllFormData();
            CsvManager csvm = new CsvManager();
            List<string> csvLines = csvm.ReadInCsvLinesAsList(pathToCsv);
            string[] csvChunks = csvm.GetCsvPages(pathToCsv);
            List<string> headerData = csvLines[0].Split(',').ToList();

            // reverse the indeces to get most recent entry first
            Array.Reverse(csvChunks);
            string currentChunk = _currentPage == -1 ? csvChunks.Last() : csvChunks[_currentPage];
            string[] chunkLines = currentChunk.Split('\n');
            List<string> extraLines = new List<string>();
            if (chunkLines.Count() > 1)
            {
                for (int i = 1; i < chunkLines.Length; i++)
                    extraLines.Add(chunkLines[i]);
            }
            List<(string, string)> headerDataPairs = new List<(string, string)>();

            for (int i = 0; i < headerData.Count(); i++)
            {
                headerDataPairs.Add((headerData[i], chunkLines[0].Split(',')[i]));

            }

            foreach (var group in _currentFormData)
            {
                foreach (var pair in headerDataPairs)
                {
                    if (pair.Item1 == group._parentLabel.Text)
                    {
                        group._data = pair.Item2;
                    }
                }
            }

            foreach(var line in extraLines)
            {
                _addNewTextBox(_parentForm._txtExtractionWorkOrder,
                    _parentForm._btnNextWorkOrder, line.Replace(",", ""));
                
            }

            RenderToFormFromData();

        }
        
        public void CacheFormData()
        {
            RefreshFormData(); // bring the formData up to speed w/ what's in the form fields
            _cachedFormData.Clear();
            List<FormDataGroup> newGroups = new List<FormDataGroup>();
            foreach (var group in _currentFormData)
            {
                var newGroup = new FormDataGroup(group._parentLabel, group._parentControl, group._data);
                newGroups.Add(newGroup);
            }
            _cachedFormData.AddRange(newGroups);
            
        }

        public void SetFormDataToCachedData()
        {
            _currentFormData.Clear();
            _currentFormData.AddRange(_cachedFormData);
        }

        public void RefreshFormData()
        {
            List<FormDataGroup> fullListToUpdate = new List<FormDataGroup>();
            fullListToUpdate.AddRange(_currentFormData);
            fullListToUpdate.AddRange(_extraFormData);
            foreach (var group in fullListToUpdate)
            {
                Control targetControl = _parentForm.Controls.Find(group._parentControl.Name, true)[0];
                if (targetControl is TextBox)
                {   
                    TextBox tb = targetControl as TextBox;
                    group._data = tb.Text.Replace(",", "");
                }
                if (targetControl is DateTimePicker)
                {
                    DateTimePicker dtp = targetControl as DateTimePicker;
                    if (group._parentLabel.Text.Contains("Time"))
                        group._data = dtp.Value.ToShortTimeString();
                    else
                        group._data = dtp.Value.ToShortDateString();
                }
                if (targetControl is ComboBox)
                {
                    ComboBox cb = targetControl as ComboBox;
                    group._data = cb.SelectedItem.ToString();
                }
                if (targetControl is NumericUpDown)
                {
                    NumericUpDown nud = targetControl as NumericUpDown;
                    group._data = nud.Value.ToString();
                }
            }
        }

        public void RenderToFormFromData()
        {
            List<FormDataGroup> fullListToUpdate = new List<FormDataGroup>();
            fullListToUpdate.AddRange(_currentFormData);
            fullListToUpdate.AddRange(_extraFormData);
            foreach (var group in fullListToUpdate)
            {
                //Text boxes, dateTimePickers, combo boxes, numeric up downs
                string data = group._data;
                Control targetControl = _parentForm.Controls.Find(group._parentControl.Name, true)[0];
                if (targetControl is TextBox)
                {
                    TextBox tb = targetControl as TextBox;
                    tb.Text = data;
                }
                if (targetControl is DateTimePicker)
                {
                    DateTimePicker dtp = targetControl as DateTimePicker;
                    if (dtp.Name == "dtpRuntime")
                    {
                        int hour = Int32.Parse(data.Substring(0, data.IndexOf(".")));
                        int minute = Int32.Parse(data.Substring(data.IndexOf(".") + 1)) * 60;

                        dtp.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, hour, minute, DateTime.Now.Second);
                    }
                    dtp.Value = DateTime.Parse(data);
                }
                if (targetControl is ComboBox)
                {
                    ComboBox cb = targetControl as ComboBox;
                    cb.SelectedIndex = cb.FindStringExact(data);
                }
                if (targetControl is NumericUpDown)
                {
                    NumericUpDown nud = targetControl as NumericUpDown;
                    if (data.Contains("."))
                        nud.Value = Decimal.Parse(data);
                    else if (data.Length == 0)
                    {
                        nud.Value = 0;
                    }
                    else
                        nud.Value = Int32.Parse(data); 
                }
            }
        }

        public void DeleteAllFormData()
        {
            _currentFormData.Clear();
        }

        public void SendCurrentFormDataToDatabase() { }

        public void EditAndSaveToCsv(string pathToCsv)
        {
            // THE LAST STAND
            // First our current CSV chunk
            Array.Reverse(_csvChunks);
            CsvManager csvm = new CsvManager();
            List<string> csvLines = csvm.ReadInCsvLinesAsList(pathToCsv);
            //List<string> headerData = csvLines[0].Split(',').ToList();

            string currentChunk = _csvChunks[_currentPage]; // <- Change this value at the end and save out
            string newChunk = "";

            // write current Form Data out to a csv chunk
            foreach (var group in _currentFormData)
            {
                newChunk += _currentFormData.IndexOf(group) < _currentFormData.Count() - 1 ? 
                    $"{group._data}," : $"{group._data}\n"; 
            }
            foreach (var group in _extraFormData)
            {
                newChunk += _extraFormData.IndexOf(group) < _extraFormData.Count() - 1 ?
                    $",,,,{group._data}\n" : $",,,,{group._data}";
            }
            var test = newChunk == currentChunk;
            _csvChunks[_currentPage] = newChunk;
            Array.Reverse(_csvChunks);
            List<string> tempList = _csvChunks.ToList();
            tempList.Insert(0, csvLines[0]);
            string csvString = ""; 
            foreach (var line in tempList)
            {
                csvString += tempList.IndexOf(line) < _csvChunks.Length ?
                   $"{line}\n" : line;
            }
            _csvChunks.Append(csvLines[0]);

            //csvm.WriteCsvDataToCsv(pathToCsv, csvString);
            File.WriteAllText(pathToCsv, csvString);

        }

        public void AppendFormDataToCsv(string pathToCsv) 
        {
            var csv = new StringBuilder();
            string headerLine = "";
            string dataLine = "";
            string extraWOLines = "";

            foreach (var group in _currentFormData)
            {
                headerLine += _currentFormData.IndexOf(group) < _currentFormData.Count() - 1  &&
                    !group._parentControl.Name.Contains("EWO_") ?
                    group._parentLabel.Text + "," : group._parentLabel.Text;

                if (group._data == "")
                {
                    group._data = " ";
                }

                dataLine += _currentFormData.IndexOf(group) < _currentFormData.Count() - 1 ?
                    group._data + "," : group._data;
            }

            foreach (var group in _extraFormData)
            {
                extraWOLines += _extraFormData.IndexOf(group) == _extraFormData.Count() - 1 ?
                    $",,,,{group._data}" : $",,,,{group._data}\n";
            }

            if (new FileInfo(pathToCsv).Length == 0)
                csv.AppendLine(headerLine);
            csv.AppendLine(dataLine.TrimEnd(',')); // This adds \n for us
            if (extraWOLines != "")
                csv.AppendLine(extraWOLines);

            CsvManager csvm = new CsvManager();
            csvm.WriteCsvDataToCsv(pathToCsv, csv.ToString());
        }

        public void ToDatabase(string pathToCsv)
        {
            const string readError = "There was an error processing the csv into form data";
            try
            {
                File.Exists(pathToCsv);
            }
            catch (Exception e)
            {
                MessageBox.Show(readError);
            }
        }
    }

    public class CsvManager
    {
        public void CreateCsv(string pathToCsv)
        {
            if (!File.Exists(pathToCsv))
            {
                MessageBox.Show($"Added new csv file because no existing file found.");
                File.Create(pathToCsv).Close();
                return;
            }

        }

        public List<string> ReadInCsvLinesAsList(string pathTocsv)
        {
            return File.ReadAllLines(pathTocsv).ToList();
        }

        public void WriteCsvDataToCsv(string pathToCsv, string csvData)
        {
            StreamWriter sw = new StreamWriter(pathToCsv, true);
            sw.Write(csvData.ToString());
            sw.Close();
        }

        public string[] GetCsvPages(string pathToCsv)
        {
            string[] lines = File.ReadAllLines(pathToCsv);
            List<string> chunks = new List<string>();

            for (int i = 1; i < lines.Length; i++)
            {
                if (!lines[i].StartsWith(","))
                {
                    chunks.Add(lines[i]);
                    for (int j = i + 1; j < lines.Length; j++)
                    {
                        if (lines[j].StartsWith(","))
                        {
                            chunks[chunks.Count() - 1] += $"\n{lines[j]}";
                        }
                        else
                            break;
                    }
                }
            }
                
            return chunks.ToArray();
        }
    }

    public class FormDataGroup
    {
        public Control _parentControl;
        public Label _parentLabel;
        public string _data;

        public FormDataGroup(Label parentLabel, Control parentControl, string data)
        {
            _parentLabel = parentLabel;
            _parentControl = parentControl;
            _data = data;
        }

        public void UpdateData(Control targetControl)
        {

        }
    }

    #endregion
}
