using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace fivem_maker
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            string scriptname = textBox2.Text;
            string path2 = path + "/" + scriptname;
                if (!Directory.Exists(path2))
                {
                Directory.CreateDirectory(path2);
                Directory.CreateDirectory(path2 + "/client");
                Directory.CreateDirectory(path2 + "/server");
                if (checkBox2.CheckState == CheckState.Checked)
                {
                    if (checkBox4.CheckState == CheckState.Checked)
                    {
                        File.WriteAllText(Path.Combine(path2, "client/main.lua"), "local Keys = {\n 	['ESC'] = 322, ['F1'] = 288, ['F2'] = 289, ['F3'] = 170, ['F5'] = 166, ['F6'] = 167, ['F7'] = 168, ['F8'] = 169, ['F9'] = 56, ['F10'] = 57, \n  	['~'] = 243, ['1'] = 157, ['2'] = 158, ['3'] = 160, ['4'] = 164, ['5'] = 165, ['6'] = 159, ['7'] = 161, ['8'] = 162, ['9'] = 163, [' - '] = 84, [' = '] = 83, ['BACKSPACE'] = 177,\n 	['TAB'] = 37, ['Q'] = 44, ['W'] = 32, ['E'] = 38, ['R'] = 45, ['T'] = 245, ['Y'] = 246, ['U'] = 303, ['P'] = 199, ['['] = 39, [']'] = 40, ['ENTER'] = 18, \n 	['CAPS'] = 137, ['A'] = 34, ['S'] = 8, ['D'] = 9, ['F'] = 23, ['G'] = 47, ['H'] = 74, ['K'] = 311, ['L'] = 182, \n 	['LEFTSHIFT'] = 21, ['Z'] = 20, ['X'] = 73, ['C'] = 26, ['V'] = 0, ['B'] = 29, ['N'] = 249, ['M'] = 244, [', '] = 82, ['.'] = 81, \n 	['LEFTCTRL'] = 36, ['LEFTALT'] = 19, ['SPACE'] = 22, ['RIGHTCTRL'] = 70, \n 	['HOME'] = 213, ['PAGEUP'] = 10, ['PAGEDOWN'] = 11, ['DELETE'] = 178, \n 	['LEFT'] = 174, ['RIGHT'] = 175, ['TOP'] = 27, ['DOWN'] = 173, \n 	['NENTER'] = 201, ['N4'] = 108, ['N5'] = 60, ['N6'] = 107, ['N + '] = 96, ['N - '] = 97, ['N7'] = 117, ['N8'] = 61, ['N9'] = 118 \n} \n  \nESX              = nil\nlocal PlayerData = {}\n\nCitizen.CreateThread(function()\n	while ESX == nil do\n		TriggerEvent('esx:getSharedObject', function(obj) ESX = obj end)\n		Citizen.Wait(0)\n	end\nend)\n\nRegisterNetEvent('esx:playerLoaded')\nAddEventHandler('esx:playerLoaded', function(xPlayer)\n  PlayerData = xPlayer\nend)\n\nRegisterNetEvent('esx:setJob')\nAddEventHandler('esx:setJob', function(job)\n  PlayerData.job = job\nend) \n\n\n\n\n function Draw3DText(x, y, z, text) \n    local onScreen,_x,_y=World3dToScreen2d(x,y,z)\n    local px,py,pz=table.unpack(GetGameplayCamCoords())\n    local dist = GetDistanceBetweenCoords(px,py,pz, x,y,z, 1) \n\n    local scale = (1/dist)*1}\n    local fov = (1/GetGameplayCamFov())*100\n    local scale = 1.9\n\n    if onScreen then\n        SetTextScale(0.0*scale, 0.18*scale)\n        SetTextFont(4)\n        SetTextProportional(1)\n        -- SetTextScale(0.0, 0.55)\n        SetTextDropshadow(0, 0, 0, 0, 255)\n        SetTextEdge(2, 0, 0, 0, 150)\n        SetTextDropShadow()\n        SetTextEntry('STRING')\n        SetTextCentre(1)\n        AddTextComponentString(text)\n        DrawText(_x,_y)\n        local factor = (string.len(text)) / 350\n        DrawRect(_x,_y+0.0115, 0.01+ factor, 0.025, 25, 25, 25, 185)\n    end\nend");
                    } else
                    {
                        File.WriteAllText(Path.Combine(path2, "client/main.lua"), "local Keys = {\n 	['ESC'] = 322, ['F1'] = 288, ['F2'] = 289, ['F3'] = 170, ['F5'] = 166, ['F6'] = 167, ['F7'] = 168, ['F8'] = 169, ['F9'] = 56, ['F10'] = 57, \n  	['~'] = 243, ['1'] = 157, ['2'] = 158, ['3'] = 160, ['4'] = 164, ['5'] = 165, ['6'] = 159, ['7'] = 161, ['8'] = 162, ['9'] = 163, [' - '] = 84, [' = '] = 83, ['BACKSPACE'] = 177,\n 	['TAB'] = 37, ['Q'] = 44, ['W'] = 32, ['E'] = 38, ['R'] = 45, ['T'] = 245, ['Y'] = 246, ['U'] = 303, ['P'] = 199, ['['] = 39, [']'] = 40, ['ENTER'] = 18, \n 	['CAPS'] = 137, ['A'] = 34, ['S'] = 8, ['D'] = 9, ['F'] = 23, ['G'] = 47, ['H'] = 74, ['K'] = 311, ['L'] = 182, \n 	['LEFTSHIFT'] = 21, ['Z'] = 20, ['X'] = 73, ['C'] = 26, ['V'] = 0, ['B'] = 29, ['N'] = 249, ['M'] = 244, [', '] = 82, ['.'] = 81, \n 	['LEFTCTRL'] = 36, ['LEFTALT'] = 19, ['SPACE'] = 22, ['RIGHTCTRL'] = 70, \n 	['HOME'] = 213, ['PAGEUP'] = 10, ['PAGEDOWN'] = 11, ['DELETE'] = 178, \n 	['LEFT'] = 174, ['RIGHT'] = 175, ['TOP'] = 27, ['DOWN'] = 173, \n 	['NENTER'] = 201, ['N4'] = 108, ['N5'] = 60, ['N6'] = 107, ['N + '] = 96, ['N - '] = 97, ['N7'] = 117, ['N8'] = 61, ['N9'] = 118 \n} \n  \nESX              = nil\nlocal PlayerData = {}\n\nCitizen.CreateThread(function()\n	while ESX == nil do\n		TriggerEvent('esx:getSharedObject', function(obj) ESX = obj end)\n		Citizen.Wait(0)\n	end\nend)\n\nRegisterNetEvent('esx:playerLoaded')\nAddEventHandler('esx:playerLoaded', function(xPlayer)\n  PlayerData = xPlayer\nend)\n\nRegisterNetEvent('esx:setJob')\nAddEventHandler('esx:setJob', function(job)\n  PlayerData.job = job\nend)");
                    }
                    
                } else
                {
                    if (checkBox4.CheckState == CheckState.Checked)
                    {
                        File.WriteAllText(Path.Combine(path2, "client/main.lua"), "ESX              = nil\nlocal PlayerData = {}\n\nCitizen.CreateThread(function()\n	while ESX == nil do\n		TriggerEvent('esx:getSharedObject', function(obj) ESX = obj end)\n		Citizen.Wait(0)\n	end\nend)\n\nRegisterNetEvent('esx:playerLoaded')\nAddEventHandler('esx:playerLoaded', function(xPlayer)\n  PlayerData = xPlayer\nend)\n\nRegisterNetEvent('esx:setJob')\nAddEventHandler('esx:setJob', function(job)\n  PlayerData.job = job\nend)");
                    }
                File.WriteAllText(Path.Combine(path2, "client/main.lua"), "ESX = nil\nlocal PlayerData = { }\n\nCitizen.CreateThread(function()\n  while ESX == nil do\n TriggerEvent('esx:getSharedObject', function(obj) ESX = obj end)\n Citizen.Wait(0)\n end\nend)\n\nRegisterNetEvent('esx:playerLoaded')\nAddEventHandler('esx:playerLoaded', function(xPlayer)\n  PlayerData = xPlayer\nend)\n\nRegisterNetEvent('esx:setJob')\nAddEventHandler('esx:setJob', function(job)\n  PlayerData.job = job\nend) \n\n\n\n\n function Draw3DText(x, y, z, text) \n local onScreen,_x,_y = World3dToScreen2d(x, y, z)\n local px,py,pz = table.unpack(GetGameplayCamCoords())\n local dist = GetDistanceBetweenCoords(px, py, pz, x, y, z, 1) \n\n local scale = (1 / dist) * 1}\n local fov = (1 / GetGameplayCamFov()) * 100\n local scale = 1.9\n\n    if onScreen then\n SetTextScale(0.0 * scale, 0.18 * scale)\n SetTextFont(4)\n SetTextProportional(1)\n-- SetTextScale(0.0, 0.55)\n SetTextDropshadow(0, 0, 0, 0, 255)\n SetTextEdge(2, 0, 0, 0, 150)\n SetTextDropShadow()\n SetTextEntry('STRING')\n SetTextCentre(1)\n AddTextComponentString(text)\n DrawText(_x, _y)\n local factor = (string.len(text)) / 350\n DrawRect(_x, _y+0.0115, 0.01 + factor, 0.025, 25, 25, 25, 185)\n end\nend");
                }
                if (checkBox1.CheckState == CheckState.Unchecked)
                {
                    if (checkBox3.CheckState == CheckState.Unchecked)
                    {
                        File.WriteAllText(Path.Combine(path2, "__resource.lua"), "resource_manifest_version '77731fab-63ca-442c-a67b-abc70f28dfa5' \n\nclient_scripts { \n 'client/main.lua'\n } \n\nserver_scripts { \n 'server/main.lua'\n}");
                    } else
                    {
                        File.WriteAllText(Path.Combine(path2, "__resource.lua"), "resource_manifest_version '77731fab-63ca-442c-a67b-abc70f28dfa5' \n\nclient_scripts { \n 'client/main.lua',\n 'config.lua'\n } \n\nserver_scripts { \n 'server/main.lua', \n 'config.lua'\n}");
                    }
                } else
                {
                    if (checkBox3.CheckState == CheckState.Unchecked)
                    {
                        File.WriteAllText(Path.Combine(path2, "__resource.lua"), "resource_manifest_version '77731fab-63ca-442c-a67b-abc70f28dfa5' \n\nclient_scripts { \n 'client/main.lua'\n } \n\nserver_scripts { \n '@mysql-async/lib/MySQL.lua',\n 'server/main.lua'\n}");
                    }
                    else
                    {
                        File.WriteAllText(Path.Combine(path2, "__resource.lua"), "resource_manifest_version '77731fab-63ca-442c-a67b-abc70f28dfa5' \n\nclient_scripts { \n 'client/main.lua',\n 'config.lua'\n } \n\nserver_scripts { \n '@mysql-async/lib/MySQL.lua',\n 'server/main.lua' \n 'config.lua'\n}");
                    }

                    if (checkBox3.CheckState == CheckState.Checked)
                    {
                        File.WriteAllText(Path.Combine(path2, "config.lua"), "Config = {}\n");
                    }
                }
                
                //File.WriteAllText(Path.Combine(path2 + "/client", "main.lua"), "ESX = nil");

                File.WriteAllText(Path.Combine(path2, "server/main.lua"), "ESX = nil\n\nTriggerEvent('esx:getSharedObject', function(obj) ESX = obj end)\n");


                MessageBox.Show("Script skapat!");
            }
            else
            {
                MessageBox.Show("Det finns redan ett script med det namnet");
                textBox2.Clear();
            }
        }


        private void Button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = false;
            fbd.Description = "Välj vilken mapp du vill skapa scriptet i";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            
            textBox1.Clear();
            textBox1.Text = fbd.SelectedPath;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox2_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.CheckState == CheckState.Checked)
            {
                checkBox3.Text = "Använd config";
            } else
            {
                checkBox3.Text = "Use config";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                checkBox7.Text = "Svenska";
            }
            else
            {
                checkBox7.Text = "English";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                checkBox1.Text = "Använd MySQL Async";
            }
            else
            {
                checkBox1.Text = "use MySQL Async";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                checkBox2.Text = "Använd Local keys";
            }
            else
            {
                checkBox2.Text = "use Local keys";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                label6.Text = "Script namn";
            } else
            {
                label6.Text = "Script name";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                label5.Text = "Script lokation";
            } else
            {
                label5.Text = "Script location";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                button1.Text = "Välj dir";
            } else
            {
                button1.Text = "Choose Dir";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                label7.Text = "Funktioner";
            }
            else
            {
                label7.Text = "Functions";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                button2.Text = "Skapa script";
            }
            else
            {
                button2.Text = "Create script";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                label8.Text = "Mer kommer snart";
            }
            else
            {
                label8.Text = "More comming soon";
            }

            if (checkBox7.CheckState == CheckState.Checked)
            {
                button3.Text = "Min hemsida";
            }
            else
            {
                button3.Text = "My website";
            }


        }
        
        private void Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://memedeveloping.se");
        }
    }
}
