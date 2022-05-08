using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectGUIDraft
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        // Lee Salazar Chavez //
        // Added timer to Splash screen //
        private void timerSplash_Tick(object sender, EventArgs e)
        {
            timerSplash.Start();
            this.Close();
        }
    }
}

/*C O M M E N T S:
 * Super nice! The splash window closed a little too fast for me, but the background with fresh vegetable is nice. The Exit button on the main page is a NO NO! You do not want the client to close your app. 
 * You will go out of business. Must remove that button.  Another issue is lack of description. That is very important. All menus tell the clint what is in the dish. 
 * A simple ToolTip for each image would have done it. Images look very good. I would have added a few more salads and desserts. Clicking on the images and use of NumberUpDown are done perfectly. 
 * Lining up the prices in the payment form would have been nice. The same thing would have been nice in the receipt. The check box to round the total is very nice. 
 * As I told you in the last lecture, that is my habit. Thank you for doing it for me. The Exit button on the last form should be removed too. Do not expect the client to clean up things for you.  
 * What if they do not? Do you want to leave the screen for the next client? You must reset the screen automatically to have it ready for the next client. You can even do it  automatically after a few minutes. 
 * I was not able to produce any errors, which is FANTASTIC. I am not sure why you made your methods static!  You only save a file at the end; why do you have file operations in two forms? 
 * A few little things can improve the program, but I am not going to take off any points. You guys did a great job! I guess we all have to thank Lee for being a great project manager.
 * -Matt Pakbaz, Jul 18, 2021
 * - CS Professor at LATTC
 * Grade: 200/200 
 */