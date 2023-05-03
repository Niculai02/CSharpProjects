using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Workers
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            groupBoxWorker.Enabled = true;
            groupBoxOfficer.Enabled = false;
            groupBoxManager.Enabled = false;
            groupBoxDirector.Enabled = false;
            _selectedType = WorkerType.Worker;

            _workers = new List<Worker>();
            _officers = new List<Officer>();
            _managers = new List<Manager>();
            _directors = new List<Director>();
        }

        private WorkerType _selectedType;
        private List<Worker> _workers;
        private List<Officer> _officers;
        private List<Manager> _managers;
        private List<Director> _directors;

        private void radioButtonWorker_Click(object sender, EventArgs e)
        {
            groupBoxWorker.Enabled = true;
            groupBoxOfficer.Enabled = false;
            groupBoxManager.Enabled = false;
            groupBoxDirector.Enabled = false;
            _selectedType = WorkerType.Worker;
        }

        private void radioButtonOfficer_Click(object sender, EventArgs e)
        {

            groupBoxWorker.Enabled = false;
            groupBoxOfficer.Enabled = true;
            groupBoxManager.Enabled = false;
            groupBoxDirector.Enabled = false;
            _selectedType = WorkerType.Officer;
        }

        private void radioButtonManager_Click(object sender, EventArgs e)
        {

            groupBoxWorker.Enabled = false;
            groupBoxOfficer.Enabled = false;
            groupBoxManager.Enabled = true;
            groupBoxDirector.Enabled = false;
            _selectedType = WorkerType.Manager;
        }

        private void radioButtonDirector_Click(object sender, EventArgs e)
        {

            groupBoxWorker.Enabled = false;
            groupBoxOfficer.Enabled = false;
            groupBoxManager.Enabled = false;
            groupBoxDirector.Enabled = true;
            _selectedType = WorkerType.Director;
        }

        private void buttonAddWorker_Click(object sender, EventArgs e)
        {
            if (_selectedType == WorkerType.Worker)
            {
                _workers.Add (new Worker(textBoxName.Text, Convert.ToDouble(textBoxBasicSalary.Text)));

            }

            if (_selectedType == WorkerType.Officer)
            {
                _officers.Add( new Officer(textBoxName.Text, Convert.ToDouble(textBoxBasicSalary.Text), Convert.ToDouble(textBoxBonus.Text)));
            }

            if (_selectedType == WorkerType.Director)
            {
                _directors.Add(new Director(textBoxName.Text, Convert.ToDouble(textBoxBasicSalary.Text), Convert.ToDouble(textBoxBonus.Text), Convert.ToDouble(textBoxDirectorAllowance.Text)));
            }

            if (_selectedType == WorkerType.Manager)
            {
                _managers.Add(new Manager(textBoxName.Text, Convert.ToDouble(textBoxBasicSalary.Text), Convert.ToDouble(textBoxBonus.Text), Convert.ToDouble(textBoxManagerAllowance.Text)));
            }
        }

        private void buttonListWorkers_Click(object sender, EventArgs e)
        {
            textBoxResults.Text = "\r\nWorkers:\r\n";
            _workers.ForEach(p => textBoxResults.Text += p.Name() + " ");
            textBoxResults.Text += "\r\nOfficers:\r\n";
            _officers.ForEach(p => textBoxResults.Text += p.Name() + " ");     
            textBoxResults.Text += "\r\nManagers:\r\n";
            _managers.ForEach(p => textBoxResults.Text += p.Name() + " ");
            textBoxResults.Text += "\r\nDirectors:\r\n";
            _directors.ForEach(p => textBoxResults.Text += p.Name() + " ");
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonWorker_CheckedChanged(object sender, EventArgs e)
        {

        }
    }

    public enum WorkerType {Worker, Officer, Manager, Director } 



}
