   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	       FuneralServices.MenCros   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Title$+  %Информация о крестаx��5	   	   $��610.333��6&   $��942.5��67   
������  � 
ResizeMode$ NoResize=�6w    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � $��0,0,-102,-21q�6   ��5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��3,0,100,-83q�6#   ��5      �� 5      .��5      �  � Color$ 	#FF8B117A��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF394F9B��6#   $ 1Q�65   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��154,0,104,455q�6g   $	��436��6~   �� 6�   $+�%Информация о крестаx��6�   �� 6�   6�   �� 5   
   $��imag/coffinBla.png��6   $��702,10,4,334q�6,    J� RenderTransformOrigin$ 0.664,0.083&�6B   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 Grid��5   /   	   AutoGenerateColumns	 .  $��10(�6=   $��0,49,336,-83q�6K   $
��Bold"�6a   
   CanUserAddRows
 .  ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � $ 	#FF4F2895��6#   $ 0.704Q�65   � 5       $ 	#FFA92DC5��6#   $
 0.17Q�65   5!         Columns 5#      0  *System.Windows.Controls.DataGridTextColumn  5$         FontSize$ 10Q�6K   ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Класс креста��6k      Width5  /System.Windows.Controls.DataGridLengthConverter$	 140 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ 	classCros�6�     5%      $ 10Q�6I    . $ Тип креста��6i   $	 130 6}    6%   �� $ typeCros�6}     5&      $ 10Q�6K    . $, &Количество на складе��6k   $	 160 6�    6%   �� $ 	countSkCr�6�     5'      $ 10Q�6J    . $ Цена креста��6j   $	 100 6    6%   �� $ 	solidCros�6   4  .System.Windows.Controls.DataGridTemplateColumn  5(      $ Кресты��6)   $ * 69   -   5        Изоброжение��   CellTemplate 5)      �� 5*      .R�5+      ��  ��Name$ IВMM��6%   $	��120��6[   ��64   �� $ imageCrosses�6[   5,      5.      51      �� 52   
   $��15(�6   $��702,192,36,-83q�6!   .@�53      �� $��1q�6   .��54      ��  �� Orientation$ 
Horizontal=�6   .+�55      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�6.   $��15q�6:   �� 56      -   5         ��Name$ Search��56   9   $��Center=�6   $	��174��6I   $��34��6U   57      58      �� 59      $��1q�6   .��5:      �� $ 
Horizontal=�6   .+�5;        $ 	SearchAdd=�6.   $��15q�6?   �� 5<      -   5        $��
Поиск��5<       &  "MaterialDesignToolForegroundButton#��[  6B   $��Center=�6~   5=      5>      �� 5?      $��1q�6   .��5@      �� $ 
Horizontal=�6   .+�5A        $	 Add=�6.   $��15q�69   �� 5B      -   5        $��Добавление��5B      #��[  6E   $��Center=�6�   5C      5D      �� 5F      $��1q�6   .��5G      �� $ 
Horizontal=�6   .+�5H        $
 Edit=�6.   $��15q�6:   �� 5I      -   5        $"��Редактирование��5I      #��[  6K   $��Center=�6�   5J      5K      �� 5L      $��1q�6   .��5M      �� $ 
Horizontal=�6   .+�5N        $ Delete=�6.   $��15q�6<   �� 5O      -   5        $��Удаление��5O      #��[  6E   $��Center=�6�   5P      5Q      �� 5R      $��1q�6   .��5S      �� $ 
Horizontal=�6   .+�5T        $ 	ArrowBack=�6.   $��15q�6?   �� 5U      -	   5        $��
Назад��5U      #��[  6<   $��Center=�6x   5V      5W      �� 5X      $��1q�6   .��5Y      �� $ 
Horizontal=�6   .+�5Z        $	 Add=�6.   $��15q�69   �� 5[      -
   5        $��btnOpenFile��5[   <   $-��'Добавить изоброжение��6   #��[  6i   $��Center=�6�   5\      5]      5^      5a      5b      