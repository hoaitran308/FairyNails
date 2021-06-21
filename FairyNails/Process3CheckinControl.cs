using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FairyNails
{
    public partial class Process3CheckinControl : UserControl
    {
        DBDataContext db;
        public Process3CheckinControl()
        {
            InitializeComponent();
        }

        private void Process3CheckinControl_Load(object sender, EventArgs e)
        {
            db = new DBDataContext();
        }
        private void LoadServices(int id)
        {
            List<Service> listServices = (from s in db.Services
                                          where s.type == id
                                          select s).ToList<Service>();

        }
    }
}
