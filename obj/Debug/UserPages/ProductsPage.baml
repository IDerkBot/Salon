   M S B A M L   `   `   `  ����  SalonApp%    SalonApp.UserPages.ProductsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  Products��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��410* �6   6,   �� 5      $��30 �6   6*   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
DGProducts��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Продукт��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 250* 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *Name+6^     5      $ 
Сумма��6%   $	 150 6N    64   �� *Price+6\   5      �� 5   
   -   5        $��InMenu��5   f   $��В меню��6   $��1��6"   $��Center=�6/   $��Right=�6J   6�   5      5      