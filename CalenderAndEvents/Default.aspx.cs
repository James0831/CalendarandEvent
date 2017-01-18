using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] calendarEvents = new string[5, 2];
    protected void Page_Load(object sender, EventArgs e)
    {
        calendarEvents[0, 0] = "4/12/2017";
        calendarEvents[0, 1] = "My Birthday";
        calendarEvents[1, 0] = "4/12/2017";
        calendarEvents[1, 1] = "Party";
        calendarEvents[2, 0] = "5/1/2017";
        calendarEvents[2, 1] = "May Day";
        calendarEvents[3, 0] = "3/17/2017";
        calendarEvents[3, 1] = "St. Patrick's Day";
        calendarEvents[4, 0] = "7/4/2017";
        calendarEvents[4, 1] = "Independece Day";

 
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = Calendar1.SelectedDate.ToShortDateString();
        for (int i = 0; i < 5; i++)
        {
            if (Calendar1.SelectedDate.ToShortDateString() == (calendarEvents[i, 0]))
            {
                Label1.Text += " " + calendarEvents[i, 1];
                
            }
        }



        
        
    }
}