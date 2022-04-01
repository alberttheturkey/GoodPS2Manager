using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodPS2Manager
{
    public partial class ArtDownload_Form : Form
    {
        ImageDownloader imageDownloader;
        OPLFolderStructure currentOPLFolder;
        public ArtDownload_Form(OPLFolderStructure currentOPLFolder, ImageDownloader imageDownloader)
        {
            this.imageDownloader = imageDownloader;
            this.currentOPLFolder = currentOPLFolder;

            InitializeComponent();
        }
    }
}
