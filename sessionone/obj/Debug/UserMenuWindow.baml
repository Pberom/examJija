   M S B A M L   `   `   `  ?????  ;exam, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:examexam  5   	       exam.UserMenuWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:exam     5   	     ? Title$  UserMenu??5	   	   $	??450??6   $	??800??6'   .??5
      ?  ? RowDefinitions 5   
   ?? 5      $	??15* ?6   ?? 5      $	??15* ?6   ?? 5      $	??15* ?6   ?? 5      $
??100* ?6    ? ColumnDefinitions 5   
   ?? 5      $
??115* ?6   ?? 5      $
??215* ?6   ?? 5      $
??225* ?6   ?? 5      $
??250* ?6   .+?5   
   c? $??30??6   $	??Top=?6   $??4??66   $??0??6J   $??2??6W   .@?5      ?? -   5        $??
exitButton??5   $   $
??Exit??6   6I   5      &   System.Windows.Controls.DataGrid  5   
   -   5        $??logGrid??5   ]   ???#FFFACB$??3??6(   $??4??65   $??
20,0,20,20q?6I      AutoGenerateColumns .     RowStyle 5      ?? 5       ?? 
TargetType)  #System.Windows.Controls.DataGridRow"  6   ?5      ?? 5       ?? Property ? ?? ?? Value 67   ?? *code+6P   5!         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$      ,  &System.Windows.Controls.DataGridColumn	   Header$
	 Date??6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6T   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   ?? *dateFormated+6`     5%      $	 
Login time??6%   $
 * 6_    69   ?? *enterFormatedTime+6k     5&      $	 Logout time??6%   $
 * 6_    6:   ?? *exitFormatedTime+6k     5'      $	 Time spent on system??6%   $
 * 6a    6C   ?? *	timeSpend+6m     5(      $!	 Unsuccessfull logout reason??6%   $
 * 6h    6J   ?? *	ExitCause+6t   5*      ?? 5+   
   -   5         ??Name$ helloTextBlock??5+      $??2??6,   $??20, 0, 0, 0q?6@   $??1??6U   6d   ?? 5,   
   -   5        $ tickTextBlock??5,      $??2??6+   $??2??68   ?? 5-   
   -   5        $ crashTextBlock??5-      $??2??6,   $??3??69   5.      5/      