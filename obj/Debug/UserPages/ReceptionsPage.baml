   M S B A M L   `   `   `  ����  SalonApp'    !SalonApp.UserPages.ReceptionsPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        N� Title$  
Receptions��5      .��5
      �  � RowDefinitions 5   
   �� 5      $
��415* �6   �� 5      $��30 �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DGReceptions��5         AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Мастер��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$
 250* 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Master.Name+6U     5      $ Клиент��6%   $
 250* 6U    65   �� *Client.Name+6U     5      $ Дата приёма��6%   $ 80 6S    6:   �� *Date+6S     5      $ Время приёма��6%   $ 90 6T    6;   �� *Time+6T     5      $ Услуги��6%   $
 100* 6V    65   �� *Service.Name+6V     5      $ Товары��6%   $
 100* 6V    65   �� *Product.Name+6V     5      $ 
Сумма��6%   $ 80 6L    64   �� *Sum+6L   5      �� 5   
   -   5        $��InMenu��5   K   $��В меню��6   $��1��6"   $��Right=�6/   $��80��6n   �� 5   
   -   5        $��ReceptionAdd��5   X   $*��$Записаться на прием��6   $��1��6/   $��Right=�6<   $��0,0,85,0q�6l   $	��150��6�   �� 5   
   -   5        	 ��Name$	 Refresh��5   M   $��Обновить��6   $��1��6$   $��Right=�61   $��	0,0,240,0q�6t   $��80��6�   �� 5   
   -   5        
 ��Name$
 Alert��5   W   $��1��6   $��Center=�6!   $
��Left=�6<   $	��200��6f   5      5      