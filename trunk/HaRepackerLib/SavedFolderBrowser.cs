﻿/*  HaRepacker - WZ extractor and repacker
 * Copyright (C) 2009, 2010 haha01haha01
   
 * This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

 * This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

 * You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HaRepackerLib
{
    public static class SavedFolderBrowser
    {
        public static string Show(string description)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog() { Description = description };
            if (ApplicationSettings.LastBrowserPath != "") dialog.SelectedPath = ApplicationSettings.LastBrowserPath;
            if (dialog.ShowDialog() != DialogResult.OK) return "";
            return ApplicationSettings.LastBrowserPath = dialog.SelectedPath;
        }
    }
}