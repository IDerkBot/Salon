   M S B A M L   `   `   `  ����  SalonApp*    $SalonApp.AdminPages.ClientsAdminPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  ClientAdminPage��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��390* �6   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGClientAdmin��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 100* 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Name+6K     5      $ Дата рождения��6%   $	 100 6\    6<   �� *YearOfBirth+6\     5      $ 
Адрес��6%   $
 100* 6P    64   �� *	Address+6P     5      $ Пол��6%   $ 75 6M    62   �� *Gender+6M   4  .System.Windows.Controls.DataGridTemplateColumn  5      $	 180 6)   	   CellTemplate	 5      �� 5      .R�5      �� $��BtnEdit��6=   -   5        $ ��Редактировать��5   %   6L   5      5      5      �� 5   
   -   5        $��BtnAdd��5   L   $��Добавить��6   $��1��6$   $
��Left=�61   6Z   �� 5    
   -   5        $��	BtnDelete��5    L   $��Удалить��6   $��1��6#   $��Right=�60   6]   �� 5!   
   -   5        $��InMenu��5!   K   $��В меню��6   $��2��6"   $��Right=�6/   6Y   5"      5#      