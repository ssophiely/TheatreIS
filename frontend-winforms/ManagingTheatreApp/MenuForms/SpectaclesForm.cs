using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace TheTheatre
{
    public partial class SpectaclesForm : Form
    {
        public Form ReturnForm;

        public SpectaclesForm()
        {
            InitializeComponent();
        }

        //private void Close_Click(object sender, EventArgs e)
        //{
        //    Close();
        //    ReturnForm.Close();
        //}

        //private void Back_Click(object sender, EventArgs e)
        //{
        //    ReturnForm.Show();
        //    this.Close();
        //}

        //private void Shows_Load(object sender, EventArgs e)
        //{
        //    shows_t.RowTemplate.MinimumHeight = 35;
        //    Shows_Update();
        //    inshow_t.RowTemplate.MinimumHeight = 25;
        //    allworkers_t.RowTemplate.MinimumHeight = 25;
        //    Allworkers_Update();
        //}

        //public void Shows_Update()
        //{
        //    using (TheTheatreContext db = new TheTheatreContext())
        //    {
        //        shows_t.Rows.Clear();
        //        var shows = db.Shows.ToList();
        //        foreach (Show sh in shows)
        //        {
        //            shows_t.Rows.Add(sh.ShowName);
        //        }
        //    }
        //    if (shows_t.Rows.Count > 0)
        //    {
        //        shows_t[0, 0].Selected = false;
        //    }
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

        //private void shows_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var senderGrid = (DataGridView)sender;
        //    using (TheTheatreContext db = new TheTheatreContext())
        //    {
        //        if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        //        e.ColumnIndex == 1)
        //        {
        //            new ShowView(shows_t[0, e.RowIndex].Value.ToString()).ShowDialog();
        //        }
        //        else if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        //            e.ColumnIndex == 2)
        //        {
        //            new ShowEdit(shows_t[0, e.RowIndex].Value.ToString()) { ReturnForm = this }.ShowDialog();
        //        }
        //        else
        //        {
        //            MessageBox.Show(
        //             $"Спектакль \"{shows_t[0, e.RowIndex].Value}\" удален",
        //             "Информация",
        //             MessageBoxButtons.OK,
        //             MessageBoxIcon.Information,
        //             MessageBoxDefaultButton.Button1,
        //             MessageBoxOptions.DefaultDesktopOnly);
        //            this.Activate();
        //            Show show = db.Shows.Where(sh => sh.ShowName == shows_t[0, e.RowIndex].Value.ToString()).First();
        //            db.Shows.Remove(show);
        //            db.SaveChanges();
        //            Shows_Update();
        //        }
        //    }
        //}

        //private void allworkers_t_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    var senderGrid = (DataGridView)sender;

        //    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
        //        e.ColumnIndex == 3)
        //    {
        //        new EnterRole(Convert.ToInt32(allworkers_t[2, e.RowIndex].Value),
        //            allworkers_t[0, e.RowIndex].Value.ToString())
        //        { ReturnForm = this }.ShowDialog();
        //    }
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

        //private void add_Click(object sender, EventArgs e)
        //{
        //    if (show_name.Text == "" || description_tb.Text == "" || hall_cb.Text == "" || (hour_nud.Value == 0 && minutes_nud.Value == 0)
        //        || min_price.Value == 0 || max_price.Value == 0)
        //    {
        //        MessageBox.Show(
        //               "Заполните все поля",
        //               "Ошибка",
        //               MessageBoxButtons.OK,
        //               MessageBoxIcon.Exclamation,
        //               MessageBoxDefaultButton.Button1,
        //               MessageBoxOptions.DefaultDesktopOnly);
        //        this.Activate();
        //        return;
        //    }
        //    if (inshow_t.Rows.Count == 0)
        //    {
        //        MessageBox.Show(
        //               "Добавьте участников спектакля",
        //               "Ошибка",
        //               MessageBoxButtons.OK,
        //               MessageBoxIcon.Exclamation,
        //               MessageBoxDefaultButton.Button1,
        //               MessageBoxOptions.DefaultDesktopOnly);
        //        this.Activate();
        //        return;
        //    }
        //    string name = show_name.Text;
        //    string description = description_tb.Text;
        //    string hall = hall_cb.Text;
        //    int hour = (int)hour_nud.Value;
        //    int minutes = (int)minutes_nud.Value;
        //    int minprice = (int)min_price.Value;
        //    int maxprice = (int)max_price.Value;
        //    Show show = new Show
        //    {
        //        ShowName = name,
        //        Duration = hour + minutes / 60,
        //        Minprice = minprice,
        //        Maxprice = maxprice,
        //        Hall = hall,
        //        Description = description
        //    };
        //    using (TheTheatreContext db = new TheTheatreContext())
        //    {
        //        db.Shows.Add(show);
        //        for (int i = 0; i < inshow_t.Rows.Count; i++)
        //        {
        //            int id = Convert.ToInt32(inshow_t.Rows[i].Cells[2].Value);
        //            TheatreWorker worker = db.TheatreWorkers.Where(w => w.TheatreWorkerId == id).First();
        //            show.Roles.Add(new Role { TheatreWorker = worker, RoleName = inshow_t.Rows[i].Cells[1].Value.ToString() });
        //        }
        //        db.SaveChanges();
        //    }
        //    Shows_Update();
        //    MessageBox.Show(
        //             $"Спектакль \"{name}\" создан",
        //             "Информация",
        //             MessageBoxButtons.OK,
        //             MessageBoxIcon.Information,
        //             MessageBoxDefaultButton.Button1,
        //             MessageBoxOptions.DefaultDesktopOnly);
        //    this.Activate();

        //    // Очистка
        //    inshow_t.Rows.Clear();
        //    Allworkers_Update();
        //    show_name.Text = "";
        //    description_tb.Text = "";
        //    hall_cb.Text = "";
        //    hour_nud.Value = 0;
        //    minutes_nud.Value = 0;
        //    min_price.Value = 0;
        //    max_price.Value = 0;
        //}
    }
}
