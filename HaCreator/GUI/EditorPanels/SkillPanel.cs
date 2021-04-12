/* Copyright (C) 2015 haha01haha01

* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/. */

using HaCreator.CustomControls;
using HaCreator.MapEditor;
using HaCreator.MapEditor.Info;
using MapleLib.WzLib;
using MapleLib.WzLib.WzProperties;
using MapleLib.WzLib.WzStructure.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HaCreator.Wz;
using MapleLib.WzLib.WzStructure;
using WeifenLuo.WinFormsUI.Docking;

namespace HaCreator.GUI.EditorPanels
{
    public partial class SkillPanel : UserControl
    {
        private HaCreatorStateManager hcsm;

        public SkillPanel ()
        {
            InitializeComponent ();
        }

        /*public void Initialize(HaCreatorStateManager hcsm)
        {
            this.hcsm = hcsm;
            hcsm.SetObjPanel(this);

            List<string> sortedSkillSets = new List<string>();
            foreach (KeyValuePair<string, WzImage> oS in Program.InfoManager.SkillSets)
                sortedSkillSets.Add(oS.Key);
            sortedSkillSets.Sort();
            foreach (string oS in sortedSkillSets)
                skillSetListBox.Items.Add(oS);
           
        }

        /// <summary>
        /// 000.img
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void objSetListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (skillSetListBox.SelectedItem == null) 
                return;

            objL0ListBox.Items.Clear();
            objL1ListBox.Items.Clear();
            objImagesContainer.Controls.Clear();
            WzImage oSImage = Program.InfoManager.SkillSets[(string)skillSetListBox.SelectedItem];
            if (!oSImage.Parsed)
            {
                oSImage.ParseImage();
            }
            foreach (WzImageProperty l0Prop in oSImage["skill"].WzProperties)
            {
                objL0ListBox.Items.Add(l0Prop.Name);
            }
            // select the first item automatically
            if (objL0ListBox.Items.Count > 0)
            {
                objL0ListBox.SelectedIndex = 0;
            }
        }
/// <summary>
/// 0001003
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void objL0ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (objL0ListBox.SelectedItem == null)
                return;

            objL1ListBox.Items.Clear();
            objImagesContainer.Controls.Clear();
            
            foreach (string oS in HaCreator.Wz.WzFileManager.SKILL_ICONS)
                objL1ListBox.Items.Add(oS);
            
            /*WzImageProperty l0Prop = Program.InfoManager.SkillSets[(string)skillSetListBox.SelectedItem]["skill"][(string)objL0ListBox.SelectedItem];
            foreach (WzImageProperty l1Prop in l0Prop.WzProperties)
            {
                objL1ListBox.Items.Add(l1Prop.Name);
            }  #1#          
            // select the first item automatically
            if (objL1ListBox.Items.Count > 0)
            {
                objL1ListBox.SelectedIndex = 0;
                objItem_Click (objImagesContainer.Controls[0], default);
            }
            
            /*objL1ListBox.Items.Clear();
            foreach (string oS in HaCreator.Wz.WzFileManager.SKILL_ICONS)
                objL1ListBox.Items.Add(oS);#1#
        }

/// <summary>
/// icon
/// </summary>
/// <param name="sender"></param>
/// <param name="e"></param>
        private void objL1ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            lock (hcsm.MultiBoard)
            {
                if (objL1ListBox.SelectedItem == null) return;
                objImagesContainer.Controls.Clear();
                WzImageProperty l1Prop = Program.InfoManager.SkillSets[(string)skillSetListBox.SelectedItem]["skill"][(string)objL0ListBox.SelectedItem][(string)objL1ListBox.SelectedItem];
                try
                {
                    var frame1 = l1Prop as WzCanvasProperty;
                    //foreach (WzSubProperty l2Prop in l1Prop.WzProperties)
                    {
                        
                        ObjectInfo info = new ObjectInfo(
                            frame1.GetLinkedWzCanvasBitmap(),
                            WzInfoTools.PointFToSystemPoint(frame1.GetCanvasOriginPosition()),
                            (string)skillSetListBox.SelectedItem, (string)objL0ListBox.SelectedItem, (string)objL1ListBox.SelectedItem, frame1.Name,
                            frame1);
                        
                        //ObjectInfo info = ObjectInfo.Get (frame1);
                        //ObjectInfo info = ObjectInfo.Get((string)skillSetListBox.SelectedItem, (string)objL0ListBox.SelectedItem, (string)objL1ListBox.SelectedItem, l2Prop.Name);
                        ImageViewer item = objImagesContainer.Add(frame1.GetBitmap (), frame1.Name, true);
                        item.Tag = info;
                        item.MouseDown += new MouseEventHandler(objItem_Click);
                        item.MouseUp += new MouseEventHandler(ImageViewer.item_MouseUp);
                        item.MaxHeight = UserSettings.ImageViewerHeight;
                        item.MaxWidth = UserSettings.ImageViewerWidth;
                    }
                }
                catch(InvalidCastException) 
                { 
                    return; 
                }
            }
        }

        public void OnL1Changed(string l1)
        {
            if ((string)objL1ListBox.SelectedItem == l1)
                objL1ListBox_SelectedIndexChanged(null, null);
        }

        private void objItem_Click(object sender, MouseEventArgs e)
        {
            lock (hcsm.MultiBoard)
            {
                if (!hcsm.MultiBoard.AssertLayerSelected())
                {
                    return;
                }
                hcsm.EnterEditMode(ItemTypes.Objects);
                hcsm.MultiBoard.SelectedBoard.Mouse.SetHeldInfo((ObjectInfo)((ImageViewer)sender).Tag);
                hcsm.MultiBoard.Focus();
                ((ImageViewer)sender).IsActive = true;
            }
        }*/


        public void Initialize (HaCreatorStateManager hcsm)
        {
            this.hcsm = hcsm;
            hcsm.SetObjPanel (this);

            List<string> sortedSkillSets = new List<string> ();
            foreach (KeyValuePair<string, WzImage> oS in Program.InfoManager.SkillSets)
                sortedSkillSets.Add (oS.Key);
            sortedSkillSets.Sort ();
            foreach (string oS in sortedSkillSets)
                skillSetListBox.Items.Add (oS);


            /*this.hcsm = hcsm;
            hcsm.SetTilePanel(this);

            List<string> sortedTileSets = new List<string>();
            foreach (KeyValuePair<string, WzImage> tS in Program.InfoManager.TileSets)
                sortedTileSets.Add(tS.Key);
            sortedTileSets.Sort();
            foreach (string tS in sortedTileSets)
                tileSetList.Items.Add(tS);*/
        }


        private void objSetListBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            LoadTileSetList ();
        }

        public void LoadTileSetList ()
        {
            /*if (skillSetListBox.SelectedItem == null) 
                return;

            objL0ListBox.Items.Clear();
            objL1ListBox.Items.Clear();
            objImagesContainer.Controls.Clear();
            WzImage oSImage = Program.InfoManager.SkillSets[(string)skillSetListBox.SelectedItem];
            if (!oSImage.Parsed)
            {
                oSImage.ParseImage();
            }
            foreach (WzImageProperty l0Prop in oSImage["skill"].WzProperties)
            {
                objL0ListBox.Items.Add(l0Prop.Name);
            }
            // select the first item automatically
            if (objL0ListBox.Items.Count > 0)
            {
                objL0ListBox.SelectedIndex = 0;
            }
            
            WzImageProperty l1Prop = Program.InfoManager.SkillSets[(string)skillSetListBox.SelectedItem]["skill"][(string)objL0ListBox.SelectedItem][(string)objL1ListBox.SelectedItem];
            try
            {
                var frame1 = l1Prop as WzCanvasProperty;
                //foreach (WzSubProperty l2Prop in l1Prop.WzProperties)
                {
                        
                    ObjectInfo info = new ObjectInfo(
                        frame1.GetLinkedWzCanvasBitmap(),
                        WzInfoTools.PointFToSystemPoint(frame1.GetCanvasOriginPosition()),
                        (string)skillSetListBox.SelectedItem, (string)objL0ListBox.SelectedItem, (string)objL1ListBox.SelectedItem, frame1.Name,
                        frame1);
                        
                    //ObjectInfo info = ObjectInfo.Get (frame1);
                    //ObjectInfo info = ObjectInfo.Get((string)skillSetListBox.SelectedItem, (string)objL0ListBox.SelectedItem, (string)objL1ListBox.SelectedItem, l2Prop.Name);
                    ImageViewer item = objImagesContainer.Add(frame1.GetBitmap (), frame1.Name, true);
                    item.Tag = info;
                    item.MouseDown += new MouseEventHandler(objItem_Click);
                    item.MouseUp += new MouseEventHandler(ImageViewer.item_MouseUp);
                    item.MaxHeight = UserSettings.ImageViewerHeight;
                    item.MaxWidth = UserSettings.ImageViewerWidth;
                }
            }
            catch(InvalidCastException) 
            { 
                return; 
            }*/




            lock (hcsm.MultiBoard)
            {
                if (skillSetListBox.SelectedItem == null)
                    return;
                objImagesContainer.Controls.Clear ();
                /*string selectedSetName = (string)skillSetListBox.SelectedItem;
                if (!Program.InfoManager.TileSets.ContainsKey(selectedSetName))
                    return;
                WzImage tileSetImage = Program.InfoManager.TileSets[selectedSetName];
                int? mag = InfoTool.GetOptionalInt(tileSetImage["info"]["mag"]);
                foreach (WzSubProperty tCat in tileSetImage.WzProperties)
                {
                    if (tCat.Name == "info") 
                        continue;
                    {
                        foreach (WzCanvasProperty tile in tCat.WzProperties)
                        {
                            ImageViewer item = tileImagesContainer.Add(tile.GetLinkedWzCanvasBitmap(), tCat.Name + "/" + tile.Name, true);
                            item.Tag = TileInfo.Get((string)tileSetList.SelectedItem, tCat.Name, tile.Name, mag);
                            item.MouseDown += new MouseEventHandler(tileItem_Click);
                            item.MouseUp += new MouseEventHandler(ImageViewer.item_MouseUp);
                        }
                    }
                }*/

                WzImageProperty tCat = Program.InfoManager.SkillSets[(string)skillSetListBox.SelectedItem]["skill"];
                foreach (var l1Prop in tCat.WzProperties)
                {
                    var frame1 = l1Prop["icon"] as WzCanvasProperty;
                    //foreach (WzSubProperty l2Prop in l1Prop.WzProperties)
                    {

                        ObjectInfo info = new ObjectInfo (
                            frame1.GetLinkedWzCanvasBitmap (),
                            WzInfoTools.PointFToSystemPoint (frame1.GetCanvasOriginPosition ()),
                            (string)skillSetListBox.SelectedItem, (string)skillSetListBox.SelectedItem, (string)skillSetListBox.SelectedItem, frame1.Name,
                            frame1);

                        ImageViewer item = objImagesContainer.Add (frame1.GetBitmap (), frame1.Name, true);
                        item.Tag = info;
                        item.MouseDown += new MouseEventHandler (tileItem_Click);
                        item.MouseUp += new MouseEventHandler (ImageViewer.item_MouseUp);
                        item.MaxHeight = UserSettings.ImageViewerHeight;
                        item.MaxWidth = UserSettings.ImageViewerWidth;
                    }
                }
            }
        }

        void tileItem_Click (object sender, MouseEventArgs e)
        {
            lock (hcsm.MultiBoard)
            {
                if (!hcsm.MultiBoard.AssertLayerSelected ())
                {
                    return;
                }

                hcsm.EnterEditMode (ItemTypes.Objects);
                hcsm.MultiBoard.SelectedBoard.Mouse.SetHeldInfo ((ObjectInfo)((ImageViewer)sender).Tag);
                hcsm.MultiBoard.Focus ();
                ((ImageViewer)sender).IsActive = true;
            }
        }

        private void thumbnailFlowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}