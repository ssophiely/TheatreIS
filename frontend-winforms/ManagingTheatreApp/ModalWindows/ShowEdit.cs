using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheTheatre
{
    public partial class ShowEdit : Form
    {
        private string _name;
        public SpectaclesForm ReturnForm;
        public ShowEdit(string name)
        {
            InitializeComponent();
            _name = name;
        }

        //private void Change_Click(object sender, EventArgs e)
        //{
        //    using (TheTheatreContext db = new TheTheatreContext())
        //    {
        //        Show show = db.Shows.Include(sh => sh.Roles).Include(sh => sh.TheatreWorkers).
        //            Where(sh => sh.ShowName == _name).First();
        //        if (show.ShowName == name_tb.Text)
        //        {
        //            show.Duration = (float?)(h_nud.Value + m_nud.Value / 60);
        //            show.Minprice = (int?)minpr.Value;
        //            show.Maxprice = (int?)maxpr.Value;
        //            show.Description = descriptiont_tb.Text;
        //            show.Hall = hall_cb.Text;
        //            show.Roles.Clear();
        //            db.SaveChanges();
        //            for (int i = 0; i < inshow_t.Rows.Count; i++)
        //            {
        //                int id = Convert.ToInt32(inshow_t.Rows[i].Cells[2].Value);
        //                TheatreWorker worker = db.TheatreWorkers.Where(w => w.TheatreWorkerId == id).First();
        //                show.Roles.Add(new Role { TheatreWorker = worker, RoleName = inshow_t.Rows[i].Cells[1].Value.ToString() });
        //            }
        //            db.SaveChanges();
        //        }
        //        else
        //        {
        //            db.Shows.Remove(show);
        //            Show new_show = new Show
        //            {
        //                ShowName = name_tb.Text,
        //                Duration = (float?)(h_nud.Value + m_nud.Value / 60),
        //                Minprice = (int?)minpr.Value,
        //                Maxprice = (int?)maxpr.Value,
        //                Description = descriptiont_tb.Text,
        //                Hall = hall_cb.Text,
        //            };
        //            for (int i = 0; i < inshow_t.Rows.Count; i++)
        //            {
        //                int id = Convert.ToInt32(inshow_t.Rows[i].Cells[2].Value);
        //                TheatreWorker worker = db.TheatreWorkers.Where(w => w.TheatreWorkerId == id).First();
        //                new_show.Roles.Add(new Role { TheatreWorker = worker, RoleName = inshow_t.Rows[i].Cells[1].Value.ToString() });
        //            }
        //            db.Shows.Add(new_show);
        //            db.SaveChanges();
        //        }
        //    }
        //    ReturnForm.Shows_Update();
        //    MessageBox.Show(
        //             $"Данные о спектакле \"{_name}\" изменены",
        //             "Информация",
        //             MessageBoxButtons.OK,
        //             MessageBoxIcon.Information,
        //             MessageBoxDefaultButton.Button1,
        //             MessageBoxOptions.DefaultDesktopOnly);
        //    this.Activate();
        //    Close();
        //}

        //private void ShowEdit_Load(object sender, EventArgs e)
        //{
        //    using (TheTheatreContext db = new TheTheatreContext())
        //    {
        //        Show show = db.Shows.Include(sh => sh.Roles).Include(sh => sh.TheatreWorkers).
        //            Where(sh => sh.ShowName == _name).First();
        //        name_tb.Text = show.ShowName;
        //        h_nud.Value = (int)show.Duration;
        //        m_nud.Value = (int)(show.Duration % 1 * 60);
        //        minpr.Value = (int)show.Minprice;
        //        maxpr.Value = (int)show.Maxprice;
        //        descriptiont_tb.Text = show.Description;
        //        hall_cb.Text = show.Hall;

        //        foreach (Role r in show.Roles)
        //        {
        //            inshow_t.Rows.Add(r.TheatreWorker.Fullname, r.RoleName, r.TheatreWorkerId);
        //        }
        //    }
        //    Allworkers_Update();
        //}

        //public void Allworkers_Update()
        //{
        //    using (TheTheatreContext db = new TheTheatreContext())
        //    {
        //        allworkers_t.Rows.Clear();
        //        var list = inshow_t.Rows.Cast<DataGridViewRow>().Select(r => Convert.ToInt32(r.Cells[2].Value)).ToList();
        //        var workers = db.TheatreWorkers.Include(u => u.Position).ToList();
        //        foreach (TheatreWorker w in workers)
        //        {
        //            if (!list.Contains(w.TheatreWorkerId))
        //                allworkers_t.Rows.Add(w.Fullname, w.Position.PosName, w.TheatreWorkerId);
        //        }
        //    }
        //    if (allworkers_t.Rows.Count > 0)
        //    {
        //        allworkers_t[0, 0].Selected = false;
        //    }
        //}

        //public void InShow_AddRow(string name, string role, int id)
        //{
        //    inshow_t.Rows.Add(name, role, id);
        //    Allworkers_Update();
        //}

        //private void inshow_t_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var senderGrid = (DataGridView)sender;
        //    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        //       e.ColumnIndex == 3)
        //    {
        //        inshow_t.Rows.RemoveAt(e.RowIndex);
        //    }
        //    Allworkers_Update();
        //}

        //private void allworkers_t_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var senderGrid = (DataGridView)sender;

        //    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        //        e.ColumnIndex == 3)
        //    {
        //        new EnterRole(Convert.ToInt32(allworkers_t[2, e.RowIndex].Value),
        //            allworkers_t[0, e.RowIndex].Value.ToString())
        //        { ShEditForm = this }.ShowDialog();
        //    }
        //}
    }
}