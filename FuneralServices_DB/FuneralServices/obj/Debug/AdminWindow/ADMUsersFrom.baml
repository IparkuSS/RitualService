   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	   "    FuneralServices.ADMUsersFrom   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � Title$  Пользователи��5	   	   $��610.333��6   $��674.522��6/   
������  � 
ResizeMode$ NoResize=�6Z    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � $��0,0,-102,-21q�6   ��5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��3,0,100,-83q�6#   ��5      �� 5      .��5      �  � Color$ 	#FF8B117A��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF394F9B��6#   $ 1Q�65   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��203,0,74,455q�6g   $	��494��6}   �� 6�   $�Пользователи��6�   �� 6�   6�   �� 5   
   $��imag/coffinBla.png��6   $��526,10,180,334q�6,    J� RenderTransformOrigin$ 0.664,0.083&�6D   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 Grid��5   /   	   AutoGenerateColumns	 .  $��10(�6=   $��0,49,350,-83q�6K   $
��Bold"�6a   
   CanUserAddRows
 .  ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � $ 	#FF4F2895��6#   $ 0.704Q�65   � 5       $ 	#FFA92DC5��6#   $
 0.17Q�65   5!         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$         FontSize$ 10Q�6G   ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ 
Логин��6g      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6v   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ login�6v     5%      $ 10Q�6E    . $ пароль��6e   $ 70 6u    6%   �� $
 pass�6u     5&      $ 10Q�6F    . $ Роль��6f   $ 70 6t    6%   �� $
 role�6t     5'      $ 10Q�6E    . $ Имя��6e   $ 70 6r    6%   �� $
 name�6r     5(      $ 10Q�6H    . $ Фамилия��6h   $	 100 6y    6%   �� $ surName�6y   5+      �� 5,   
   $��15(�6   $��426,291,100,-152q�6!   .@�5-      �� $��1q�6   .��5.      ��  �� Orientation$ 
Horizontal=�6   .+�5/      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�6.   $��15q�6:   �� 50      -   5         ��Name$ Search��50   9   $��Center=�6   $	��174��6I   $��34��6U   51      52      �� 53      $��1q�6   .��54      �� $ 
Horizontal=�6   .+�55        $ 	SearchAdd=�6.   $��15q�6?   �� 56      -   5        $��
Поиск��56       &  "MaterialDesignToolForegroundButton#��[  6B   $��Center=�6~   57      58      �� 59      $��1q�6   .��5:      �� $ 
Horizontal=�6   .+�5;        $ Delete=�6.   $��15q�6<   �� 5<      -   5        $��Удаление��5<      #��[  6E   $��Center=�6�   5=      5>      �� 5?      $��1q�6   .��5@      �� $ 
Horizontal=�6   .+�5A        $ 	ArrowBack=�6.   $��15q�6?   �� 5B      -   5        $��
Назад��5B      #��[  6<   $��Center=�6x   5C      5D      5F      5I      5J      