   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	       FuneralServices.MtheFun   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      -   5          � Title$.  (Информация о поминках��5
   	   $	��583��6'   $	��602��64   
������  � 
ResizeMode$ NoResize=�6p    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,0,-102,-21q�6    � ColumnDefinitions 5   
   �� 5      ��5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��3,0,102,-55q�6#   ��5      �� 5      .��5      �  � Color$ 	#FF8B117A��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF394F9B��6#   $ 1Q�65   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��121,0,88,456q�6g   $	��489��6}   �� 6�   $/�) Информация о поминках��6�   �� 6�   6�   �� 5   
   $��imag/coffinBla.png��6   $��422,43,102,348q�6,    J� RenderTransformOrigin$ 0.664,0.083&�6D   &   System.Windows.Controls.DataGrid  5    
   -   5        	  Name$
	 Grid��5    /   
   AutoGenerateColumns
 .  $��10(�6=   $��0,43,299,-55q�6K   $
��Bold"�6a      CanUserAddRows .  ��5!      �� 5"       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5#      � $ 	#FF4F2895��6#   $ 0.704Q�65   � 5$      $ 	#FFA92DC5��6#   $
 0.17Q�65   5%         Columns 5(      0  *System.Windows.Controls.DataGridTextColumn  5)         FontSize$ 10Q�6I   ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Организация��6i      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6~   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ organiz�6~     5*      $ 10Q�6H    . $! номер телефона��6h   $	 180 6�    6%   �� $ numPhon�6�     5+      $ 10Q�6J    . $ цена��6j   $ * 6x    6%   �� $ 	solidFunr�6x   5.      �� 5/   
   $��15(�6   $��399,187,102,-54q�6!   .@�50      �� $��1q�6   .��51      ��  �� Orientation$ 
Horizontal=�6   .+�52      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�6.   $��15q�6:   �� 53      -   5         ��Name$ Search��53   :   $��Center=�6   $	��136��6J   $��34��6V   54      55      �� 56      $��1q�6   .��57      �� $ 
Horizontal=�6   .+�58        $ 	SearchAdd=�6.   $��15q�6?   �� 59      -   5        $��
Поиск��59       &  "MaterialDesignToolForegroundButton#��[  6B   $��Center=�6~   5:      5;      �� 5<      $��1q�6   .��5=      �� $ 
Horizontal=�6   .+�5>        $	 Add=�6.   $��15q�69   �� 5?      -   5        $��Добовление��5?      #��[  6E   $��Center=�6�   5@      5A      �� 5C      $��1q�6   .��5D      �� $ 
Horizontal=�6   .+�5E        $
 Edit=�6.   $��15q�6:   �� 5F      -   5        $"��Редактирование��5F      #��[  6K   $��Center=�6�   5G      5H      �� 5I      $��1q�6   .��5J      �� $ 
Horizontal=�6   .+�5K        $ Delete=�6.   $��15q�6<   �� 5L      -   5        $��Удаление��5L      #��[  6E   $��Center=�6�   5M      5N      �� 5O      $��1q�6   .��5P      �� $ 
Horizontal=�6   .+�5Q        $ 	ArrowBack=�6.   $��15q�6?   �� 5R      -   5        $��
Назад��5R      #��[  6<   $��Center=�6x   5S      5T      5V      5W      5X      