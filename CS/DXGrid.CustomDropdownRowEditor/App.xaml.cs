﻿// Developer Express Code Central Example:
// How to implement custom dropdown row editor for DXGrid
// 
// This example demonstrates how to edit grid row using the dropdown panel with
// editors generated automatically based on the underlying row data object. To see
// this approach in action, click the "Edit" hyperlink in the "#" grid column. To
// close dropdown panel click "Edit" again.
// This functionality is achieved by
// creating the attached behavior which generates the necessary DataRowTemplate for
// the grid row. The custom template can also be defined and assigned to the
// GridHelper.CustomTemplate property, so the custom template will be used instead
// the autogenerated template.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E4798

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;

namespace DXGrid.CustomDropdownRowEditor {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
    }
}