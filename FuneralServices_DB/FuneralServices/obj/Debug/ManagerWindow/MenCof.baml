   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	       FuneralServices.MenCof   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Title$*  $Информация о гробах��5	   	   $	��583��6%   $��1006.5��62   
������  � 
ResizeMode$ NoResize=�6t    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � $��
0,0,-8,-21q�6   ��5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��	3,0,0,-54q�6#   ��5      �� 5      .��5      �  � Color$ 	#FF8B117A��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF394F9B��6#   $ 1Q�65   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��154,0,104,455q�6g   $	��436��6~   �� 6�   $*�$Информация о гробах��6�   �� 6�   6�   �� 5   
   $��imag/coffinBla.png��6   $��821,10,10,358q�6,    J� RenderTransformOrigin$ 0.664,0.083&�6C   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 Grid��5   /   	   AutoGenerateColumns	 .  $��10(�6=   $��0,43,246,-54q�6K   $
��Bold"�6a   
   CanUserAddRows
 .  ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � $ 	#FF4F2895��6#   $ 0.704Q�65   � 5       $ 	#FFA92DC5��6#   $
 0.17Q�65   5!         Columns 5$      0  *System.Windows.Controls.DataGridTextColumn  5%         FontSize$ 10Q�6J   ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$! Материал гроба��6j      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ materCof�6�     5&      $ 10Q�6I    . $ Класс гроба��6i   $	 130 6~    6%   �� $ classCof�6~     5'      $ 10Q�6I    . $( "Цена гроба(Бел.руб)��6i   $	 130 6�    6%   �� $ solidCof�6�     5(      $ 10Q�6H    . $, &Количество на складе��6h   $	 160 6�    6%   �� $ countSk�6�   4  .System.Windows.Controls.DataGridTemplateColumn  5)      $ Изображения��6)   $ * 6>   -   5        IMM��   CellTemplate 5*      �� 5+      .R�5,      ��  ��Name$ IВMM��6%   $	��150��6Z   ��64   �� $ imageCoffin�6Z   5-      5/      51      �� 53   
   $��15(�6   $��768,196,0,-54q�6!   .@�54      �� $��1q�6   .��55      ��  �� Orientation$ 
Horizontal=�6   .+�56      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�6.   $��15q�6:   �� 57      -   5         ��Name$ Search��57   9   $��Center=�6   $	��174��6I   $��34��6U   58      59      �� 5:      $��1q�6   .��5;      �� $ 
Horizontal=�6   .+�5<        $ 	SearchAdd=�6.   $��15q�6?   �� 5=      -   5        $��
Поиск��5=       &  "MaterialDesignToolForegroundButton#��[  6B   $��Center=�6~   5>      5?      �� 5@      $��1q�6   .��5A      �� $ 
Horizontal=�6   .+�5B        $	 Add=�6.   $��15q�69   �� 5C      -   5        $��Добавление��5C      #��[  6E   $��Center=�6�   5D      5E      �� 5G      $��1q�6   .��5H      �� $ 
Horizontal=�6   .+�5I        $
 Edit=�6.   $��15q�6:   �� 5J      -   5        $"��Редактирование��5J      #��[  6K   $��Center=�6�   5K      5L      �� 5M      $��1q�6   .��5N      �� $ 
Horizontal=�6   .+�5O        $ Delete=�6.   $��15q�6<   �� 5P      -   5        $��Удаление��5P      #��[  6E   $��Center=�6�   5Q      5R      �� 5S      $��1q�6   .��5T      �� $ 
Horizontal=�6   .+�5U        $ 	ArrowBack=�6.   $��15q�6?   �� 5V      -	   5        $��
Назад��5V      #��[  6<   $��Center=�6x   5W      5X      �� 5Y      $��1q�6   .��5Z      �� $ 
Horizontal=�6   .+�5[        $	 Add=�6.   $��15q�69   �� 5\      -
   5        $��btnOpenFile��5\   <   $-��'Добавить изоброжение��6   #��[  6i   $��Center=�6�   5]      5^      5_      5b      5c      