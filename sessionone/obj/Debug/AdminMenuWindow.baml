   M S B A M L   `   `   `  ?????  ;exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:exam.assetsexam.assets  5   	   !    exam.assets.AdminMenuWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:exam.assets     5   	   $	??600??5      $	??350??5	   	     ? Title$'  !AMONIC Airlines Automation System??5
   	   $	??450??63   $	??800??6@   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $
??134* ?6   ?? 5      $
??659* ?6    ? RowDefinitions 5   
   ?? 5      $	??28* ?6   ?? 5      $	??31* ?6   ?? 5      $
??290* ?6   ?? 5      $	??71* ?6   .+?5   
   c? ???#00A0BB$??30??6(   $	??Top=?64   $??2??6L   $??0??6`   $??
0,0,-0.4,0q?6m   $??2??6?   .@?5      ?? -   5        $??addUserButton??5   =   $??Add user??6   ???#196AA66R   ?? 5      -   5        $??
exitButton??5   %   $
??Exit??6   67   5      ?? 5   
   $??1??6   $??0??6"   $??Stretch=?62   $??Center=?6P    ?? Orientation$ 
Horizontal=?6k   $??0,0,0.4,0.2q?6?   $??31??6?   .+?5      ?? $??Stretch=?6   $??Office:    ??64   6I   ?? 5      -   5        $??comboBoxOffices??5   -   ???#FFFACB$??Stretch=?6E   $??12, 0, 0, 0q?6c   $??88??6y   $??30??6?   ??5      ?? 5      .R?5       ??  ?? TextAlignment$ Center=?6$   ?? 5!      ?6   ?? *Title+5"      5#      5%      5&      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ 	usersGrid??5(   V   ???#FFFACB   
IsReadOnly .    AutoGenerateColumns .  $??0??6?   $??10q?6?   $??2??6?   $??Stretch=?6?   $??Stretch=?6?   $??2??6?      RowStyle 5)      ?? 5*      	 ?? 
TargetType)  #System.Windows.Controls.DataGridRow"	  6   ?5+      ?? 5,      
 ?? Property
 ? ?? ?? Value 67   ?? *code+6P   5.         Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$
 Name??6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ?? *name+6X     52      $ 	Last Name??6%   $ * 6U    68   ?? *
lastName+6a     53      $	 Age??6%   $ * 6J    62   ?? *age+6V     54      $
 Role??6%   $ * 6R    63   ?? *
role.Title+6^     55      $ Email??6%   $ * 6N    64   ?? *email+6Z     56      $ Office??6%   $ * 6V    65   ?? *office.Title+6b   59      ?? 5:   
   -   5         ??Name$ changeButton??5:   &   ???#196AA6$??Change Role??6S   $??3??6i   $??30??6v   $??Right=?6?   $??0,0,20,0q?6?   $??5q?6?   6?   ?? 5;   
   -   5        $??	banButton??5;   "   
???  ??$??Enable/Disable Login??6R   $??3??6q   $??1??6~   $??30??6?   $
??Left=?6?   $??20,0,0,0q?6?   $??5q?6?   6?   5=      5>      