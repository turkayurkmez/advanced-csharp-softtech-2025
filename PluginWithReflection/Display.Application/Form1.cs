using Display.SDK;

namespace Display.ApplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addPluginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Environment.CurrentDirectory;
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                //Burada, seçilen klasör içerisindeki dll'ler kontrol edilecek  ve plugin olanlar menüye eklenecek.
                List<Plug> plugs = Helper.GetPlugs(folderBrowserDialog.SelectedPath);

                addTOMenu(plugs);
            }
        }

        Dictionary<string,Plug> loadedPlugins = new Dictionary<string,Plug>();
        private void addTOMenu(List<Plug> plugs)
        {
            plugs.ForEach(p =>
            {
                ToolStripMenuItem menuItem = new ToolStripMenuItem(p.Name);
                pluginsToolStripMenuItem.DropDownItems.Add(menuItem);
                menuItem.Click += MenuItem_Click;
                loadedPlugins.Add(p.Name, p);   
            });
        }

        private void MenuItem_Click(object? sender, EventArgs e)
        {
            string name = ((ToolStripMenuItem)sender).Text;
            Plug plug = loadedPlugins[name];
            IPlug plugInstance = Helper.CreateInstance(plug);
            plugInstance.Draw(splitContainer1.Panel2.CreateGraphics(), new SolidBrush(Color.Blue), (int)numericUpDownX.Value, (int)numericUpDownY.Value, (int)numericUpDownWidth.Value, (int)(numericUpDownHeight.Value));
        }
    }
}
