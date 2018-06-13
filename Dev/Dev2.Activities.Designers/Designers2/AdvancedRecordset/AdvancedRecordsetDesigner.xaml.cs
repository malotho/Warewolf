/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2018 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using Dev2.Activities.Designers2.Core;
using Dev2.Threading;

namespace Dev2.Activities.Designers2.AdvancedRecordset
{
    public partial class AdvancedRecordsetDesigner
	{
        public AdvancedRecordsetDesigner()
        {
            InitializeComponent();
        }

        protected override AdvancedRecordsetDesignerViewModel CreateViewModel() => new AdvancedRecordsetDesignerViewModel(ModelItem, new ViewPropertyBuilder());
    }
}
    