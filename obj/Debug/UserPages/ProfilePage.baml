   M S B A M L   `   `   `  ����  SalonApp$    SalonApp.UserPages.ProfilePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      >d2http://schemas.microsoft.com/expression/blend/2008    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $��Center=�5      $��Center=�5	        N� Title$  Profile��5
      .��5      �  � ColumnDefinitions 5   
   �� 5      $��95 �6   �� 5      $	��205 �6    � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   �� 5      $��30 �6   .+�5   
   �� $��0��6   $��Center=�6!   $��Right=�6<   $��ФИО:��6X   �� 5   
   $��1��6   $��Center=�6!   $��Right=�6<   $ ��Дата рождения:��6X   �� 5   
   $��2��6   $��Center=�6!   $��Right=�6<   $��Адрес:��6X   �� 5   
   $��3��6   $��Center=�6!   $��Right=�6<   $��Пол:��6X   �� 5   
   -   5         ��Name$
 Name��5   /   $��1��6   $��0��6"   6/   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$
 Date��5   2   $��1��6   $��1��6%   6B   �� 5   
   -   5        $ Address��5   /   $��1��6   $��2��6"   6/   �� 5   
   $��1��6   $��3��6%    �� Orientation$ 
Horizontal=�62   $��Center=�6K   $��Center=�6f   .+�5       	� -   5         	�Name$ 	GenderMan��5    ?    	� 	GroupName$ Gender��6   $��Мужской��6-   6?   	� 5!      -   5        $ GenderWoman��5!   ?   $ Gender��6   $��Женский��6-   $��10,0,0,0q�6T   5"      �� 5#   
   -   5         ��Name$ InMenu��5#   q   $��2��6   $��4��6%   $��Right=�62   $	��100��6N   $��Назад в меню��6Z   $��0,0,85,0q�6�   �� 5$   
   -   5        $
 Save��5$   m   $��2��6   $��4��6%   $��Right=�62   $��80��6N   $��Сохранить��6Y   6{   5%      5&      