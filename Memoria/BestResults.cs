using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Operations;

namespace Memoria
{
    public partial class BestResults : Form
    {
        public BestResults()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void BestResults_Load(object sender, EventArgs e)
        {
            if(Operations.DataAndMethodsForMemory.RecordsDataDownload())
            {
                foreach (RecordData aRecordData in Operations.DataAndMethodsForMemory.RecordDataList)
                {
                    GamerData aGamer = Operations.DataAndMethodsForMemory.GamerNameList.FirstOrDefault(x => x.GamerID == aRecordData.GamerID);

                    if (aGamer != null)
                    {
                        ListViewItem aRecorder = new ListViewItem(aGamer.ToString());
                        aRecorder.SubItems.Add(aRecordData.ClickNumber.ToString());
                        aRecorder.SubItems.Add(aRecordData.GameTime.ToString());
                        aRecorder.SubItems.Add(aRecordData.Score.ToString());

                        listViewRecords.Items.Add(aRecorder);
                    }
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
