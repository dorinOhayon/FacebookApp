using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace FacebookWinFormsApp
{
    internal class GoBackVisitor
    {
        internal readonly List<Color> r_FormColorRange = new List<Color>
        {
            Color.DarkCyan, Color.RoyalBlue,
            Color.CadetBlue,Color.SteelBlue,
            Color.Aquamarine, Color.DeepSkyBlue, 
            Color.DodgerBlue, Color.CornflowerBlue
        };

        public void FadeFormAndGoToFeaturesForm(Form i_GoBack)
        {
            if (i_GoBack != null)
            {
                fadeOutForm(i_GoBack);
                i_GoBack.Close();
            }
            else
            {
                throw new Exception("Form is a null reference! Sorry:(");
            }
        }

        private void fadeOutForm(Form i_ToFade)
        {
            colorsOppositeDir(i_ToFade);
            colorsOppositeDir(i_ToFade);
        }

        private void colorsOppositeDir(Form i_ToFade)
        {
            r_FormColorRange.Reverse();
            foreach (Color shade in r_FormColorRange)
            {
                i_ToFade.BackColor = shade;
                i_ToFade.Refresh();
                Thread.Sleep(3);
            }
        }
    }
}
