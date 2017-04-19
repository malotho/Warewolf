/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2017 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System.Windows;
using Dev2.Studio.Interfaces;

namespace Dev2.Webs.Callbacks
{
    public class Dev2DecisionCallbackHandler : IPropertyEditorWizard
    {
        public Window Owner { get; set; }

        public string ModelData { get; set; }

        public ILayoutObjectViewModel SelectedLayoutObject => null;
    }
}
