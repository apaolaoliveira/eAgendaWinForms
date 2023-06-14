using eAgenda.Domain.TaskModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eAgenda.WinForms.TaskModule
{
    public partial class FilterTaskScreenForm : Form
    {
        public FilterTaskScreenForm()
        {
            InitializeComponent();
        }

        public TaskStatusEnum GetTaskFilter()
        {
            if (rdbDone.Checked == true)
                return TaskStatusEnum.Done;

            else if (rdbPending.Checked == true)
                return TaskStatusEnum.Pending;

            return TaskStatusEnum.All;
        }
    }
}
