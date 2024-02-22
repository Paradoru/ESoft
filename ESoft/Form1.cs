using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESoft
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (ModelDB db=new ModelDB())
            {
                var zkh = db.ResidentialComplex.Join(db.House, // второй набор
                u => u.ID, // свойство-селектор объекта из первого набора
                c => c.ResidentialComplexID, // свойство-селектор объекта из второго набора
                (u, c) => new // результат
                {
                    Name = u.Name,
                    Status = u.Status,
                    Houses = db.House.GroupBy(p=>p.ResidentialComplexID).Count(),
                    City=u.City
                });
                dataGridView1.DataSource = zkh.ToList();
            }
        }
        
    }
}
