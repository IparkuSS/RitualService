   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	       FuneralServices.MHers   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          � Title$0  *Информация о катафалке��5
   	   $	��492��6(   $��556.5��65   
������  � 
ResizeMode$ NoResize=�6s    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,0,-102,-21q�6    � ColumnDefinitions 5   
   �� 5      $
��499* �6   �� 5      $
��152* �6   ��5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��0,-4,102,32q�6#   $��2��68   ��5      �� 5      .��5      �  � Color$ 	#FF8B117A��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF394F9B��6#   $ 1Q�65   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��55,0,82,455q�6g   $	��513��6|   $��2��6�   �� 6�   $0�*Информация о катафалке��6�   �� 6�   6�   �� 5    
   $��imag/coffinBla.png��6   $��412,19,61,364q�6,    J� RenderTransformOrigin$ 0.664,0.083&�6C   $��2��6g   &   System.Windows.Controls.DataGrid  5!   
   -   5        	  Name$
	 Grid��5!   /   
   AutoGenerateColumns
 .  $��10(�6=   $��0,43,160,32q�6K   $
��Bold"�6`      CanUserAddRows .  ��5"      �� 5#       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5$      � $ 	#FF4F2895��6#   $ 0.704Q�65   � 5%      $ 	#FFA92DC5��6#   $
 0.17Q�65   5'         Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+         FontSize$ 10Q�6G   ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ 
Марка��6g      Width5  /System.Windows.Controls.DataGridLengthConverter$	 190 6v   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ brand�6v     5,      $ 10Q�6H    . $ цена��6h   $ * 6v    6%   �� $ solidHe�6v   5/      �� 50   
   $��15(�6   $��343,175,83,-54q�6!   $��2��69   .@�51      �� $��1q�6   .��52      ��  �� Orientation$ 
Horizontal=�6   .+�53      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�6.   $��15q�6:   �� 54      -   5         ��Name$ Search��54   9   $��Center=�6   $	��174��6I   $��34��6U   55      56      �� 57      $��1q�6   .��58      �� $ 
Horizontal=�6   .+�59        $ 	SearchAdd=�6.   $��15q�6?   �� 5:      -   5        $��
Поиск��5:       &  "MaterialDesignToolForegroundButton#��[  6B   $��Center=�6~   5;      5<      �� 5=      $��1q�6   .��5>      �� $ 
Horizontal=�6   .+�5?        $	 Add=�6.   $��15q�69   �� 5@      -   5        $��Добавление��5@      #��[  6E   $��Center=�6�   5A      5B      �� 5D      $��1q�6   .��5E      �� $ 
Horizontal=�6   .+�5F        $
 Edit=�6.   $��15q�6:   �� 5G      -   5        $"��Редактирование��5G      #��[  6K   $��Center=�6�   5H      5I      �� 5J      $��1q�6   .��5K      �� $ 
Horizontal=�6   .+�5L        $ Delete=�6.   $��15q�6<   �� 5M      -   5        $��Удаление��5M      #��[  6E   $��Center=�6�   5N      5O      �� 5P      $��1q�6   .��5Q      �� $ 
Horizontal=�6   .+�5R        $ 	ArrowBack=�6.   $��15q�6?   �� 5S      -   5        $��
Назад��5S      #��[  6<   $��Center=�6x   5T      5U      5V      5W      5X      