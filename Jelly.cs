using System.Windows.Forms;
using System;

namespace Jelly
{
    public partial class Jelly : Form
    {
        private readonly VAMemory vam = new VAMemory("ac_client"); // Load Assault Cube
        private static readonly int baseAddress = 0x00509B74; // Assault Cube base address
        private bool isValueSetterLoopEnabled = false; // Value Setter loop

        /* Offsets */
        private static readonly int armorAmmountOffset = 0xFC;
        private static readonly int assaultRifleAmmoOffset = 0x150;
        private static readonly int assaultRifleExtraAmmoMagazineOffset = 0x128;
        private static readonly int grenadeNumberOffset = 0x158;
        private static readonly int healthPointsOffset = 0xF8;
        private static readonly int playerVelocityOffset = 0x80;
        private static readonly int semiAutomaticPistolAmmoOffset = 0x13C;
        private static readonly int semiAutomaticPistolExtraAmmoMagazineOffset = 0x114;
        /* Offsets */

        /* Global Hacks */
        private bool isGodModeEnabled = false;
        private bool isFlyEnabled = false;
        private bool isGhostModeEnabled = false;
        /* Global Hacks */
        
        public Jelly()
        {
            InitializeComponent();
        }

        private void ValueSetterLoopCheckboxEvent(object sender, EventArgs e)
        {
            if (loopValueSetterCheckbox.Checked)
            {
                isValueSetterLoopEnabled = true;
                MessageBox.Show("Set again the value to update.", "Value Setter Loop", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { isValueSetterLoopEnabled = false; }
        }

        private void ValueSetterButtonClick(object sender, EventArgs e)
        {
            logLabel.Text = "";
            int newValue = Convert.ToInt32(valueSetterNumericUpDown.Value);

            try
            {
                int pointer;

                switch (valueSetterOffsetsListBox.SelectedItem.ToString())
                {
                    case "armorAmmount":
                        pointer = vam.ReadInt32((IntPtr)baseAddress) + armorAmmountOffset; break;

                    case "assaultRifleAmmo":
                        pointer = vam.ReadInt32((IntPtr)baseAddress) + assaultRifleAmmoOffset; break;

                    case "assaultRifleExtraAmmoMagazine":
                        pointer = vam.ReadInt32((IntPtr)baseAddress) + assaultRifleExtraAmmoMagazineOffset; break;

                    case "grenadeNumber":
                        pointer = vam.ReadInt32((IntPtr)baseAddress) + grenadeNumberOffset; break;

                    case "healthPoints":
                        pointer = vam.ReadInt32((IntPtr)baseAddress) + healthPointsOffset; break;

                    case "playerVelocity":
                        pointer = vam.ReadInt32((IntPtr)baseAddress) + playerVelocityOffset; break;

                    case "semiAutomaticPistolAmmo":
                        pointer = vam.ReadInt32((IntPtr)baseAddress) + semiAutomaticPistolAmmoOffset; break;

                    case "semiAutomaticPistolExtraAmmoMagazine":
                        pointer = vam.ReadInt32((IntPtr)baseAddress) + semiAutomaticPistolExtraAmmoMagazineOffset; break;

                    default:
                        pointer = vam.ReadInt32((IntPtr)baseAddress) + semiAutomaticPistolExtraAmmoMagazineOffset; break;
                } logLabel.Text = $"{logLabel.Text}0x{pointer:X} --> {newValue}\n";

                if (isValueSetterLoopEnabled)
                {
                    while (isValueSetterLoopEnabled)
                    {
                        vam.WriteInt32((IntPtr)pointer, newValue);
                        Application.DoEvents();
                    }
                }
                else
                {
                    vam.WriteInt32((IntPtr)pointer, newValue);
                }
            }
            catch
            {
                MessageBox.Show("No offset selected.", "Value Setter Listbox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void IsGlobalHacksFlyCheckboxEnabled(object sender, EventArgs e)
        {
            int pointer = vam.ReadInt32((IntPtr)baseAddress) + 0x338;

            if (flyCheckbox.Checked) { isFlyEnabled = true; }
            else { isFlyEnabled = false; }

            if (isFlyEnabled)
            {
                vam.WriteInt32((IntPtr)pointer, 5);
                logLabel.Text = "Fly: Enabled\n";
            }
            else
            {
                vam.WriteInt32((IntPtr)pointer, 0);
                logLabel.Text = "Fly: Disabled\n";
            }
        }

        private void IsGlobalHacksGhostModCheckboxEnabled(object sender, EventArgs e)
        {
            int pointer = vam.ReadInt32((IntPtr)baseAddress) + 0x80;

            if (ghostModeCheckbox.Checked) { isGhostModeEnabled = true; }
            else { isGhostModeEnabled = false; }

            if (isGhostModeEnabled)
            {
                vam.WriteInt32((IntPtr)pointer, 262144);
                logLabel.Text = "Ghost Mod: Enabled\n";
            }
            else
            {
                vam.WriteInt32((IntPtr)pointer, 0);
                logLabel.Text = "Ghost Mod: Disabled\n";
            }
        }

        private void IsGlobalHacksGodModCheckboxEnabled(object sender, EventArgs e)
        {
            int pointer = vam.ReadInt32((IntPtr)baseAddress) + healthPointsOffset;

            if (godModeCheckbox.Checked) { isGodModeEnabled = true; }
            else { isGodModeEnabled = false; }

            if (isGodModeEnabled)
            {
                logLabel.Text = "God Mod: Enabled\n";

                while (isGodModeEnabled)
                {
                    vam.WriteInt32((IntPtr)pointer, 1337);
                    Application.DoEvents();
                }
            }
            else
            {
                vam.WriteInt32((IntPtr)pointer, 100);
                logLabel.Text = "God Mod: Disabled\n";
            }
        }

        private void Jelly_Load(object sender, EventArgs e) { }
    }
}
