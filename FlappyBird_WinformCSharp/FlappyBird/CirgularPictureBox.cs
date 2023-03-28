using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
public class CircularPictureBox : PictureBox
{
    protected override void OnPaint(PaintEventArgs e)
    {
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(path);
            base.OnPaint(e);
        }
    }
}