   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	       FuneralServices.MenWith   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   -   5          � Title$  
Венки��5   	   $	��583��6   $��907.5��6$   
������  � 
ResizeMode$ NoResize=�6b    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,0,-102,-21q�6    � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��0,0,102,-55q�6#   ��5      �� 5      .��5      �  � Color$ 	#FF8B117A��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF394F9B��6#   $ 1Q�65   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��154,0,104,455q�6g   $	��436��6~   �� 6�   $,�&  Информация о Венках��6�   �� 6�   6�   �� 5   
   $��imag/coffinBla.png��6   $��796,0,116,311q�6,    J� RenderTransformOrigin$ 0.664,0.083&�6C   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 Grid��5   /   	   AutoGenerateColumns	 .  $��10(�6=   $��0,48,335,-55q�6K   $
��Bold"�6b   
   CanUserAddRows
 .  ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � $ 	#FF4F2895��6#   $ 0.704Q�65   � 5      $ 	#FFA92DC5��6#   $
 0.17Q�65   5          Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#         FontSize$ 10Q�6J   ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$! Название венка��6j      Width5  /System.Windows.Controls.DataGridLengthConverter$	 120 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ classWre�6�     5$      $ 10Q�6I    . $ Тип венка��6i   $	 120 6|    6%   �� $ typeWrea�6|     5%      $ 10Q�6F    . $ Класс венка��6f   $	 150 6{    6%   �� $ typeV�6{     5'      $ 10Q�6F    . $ Цена��6f   $	 120 6t    6%   �� $ solid�6t   4  .System.Windows.Controls.DataGridTemplateColumn  5(      $ 
Венки��6)   $ * 68   -   5        IMM��   CellTemplate 5)      �� 5*      .R�5+      ��  ��Name$ IВMM��6%   -   5        $	��100��5+   m   ��64   �� $ imageCh�6m   5,      5.      50      �� 51   
   $��15(�6   $��669,176,36,-54q�6!   .@�52      �� $��1q�6   .��53      ��  �� Orientation$ 
Horizontal=�6   .+�54      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�6.   $��15q�6:   �� 55      -   5         ��Name$ Search��55   9   $��Center=�6   $	��140��6I   $��34��6U   56      57      �� 58      $��1q�6   .��59      �� $ 
Horizontal=�6   .+�5:        $ 	SearchAdd=�6.   $��15q�6?   �� 5;      -   5        $��
Поиск��5;       &  "MaterialDesignToolForegroundButton#��[  6B   $��Center=�6~   5<      5=      �� 5>      $��1q�6   .��5?      �� $ 
Horizontal=�6   .+�5@        $	 Add=�6.   $��15q�69   �� 5A      -   5        $��Добавление��5A      #��[  6E   $��Center=�6�   5B      5C      �� 5E      $��1q�6   .��5F      �� $ 
Horizontal=�6   .+�5G        $
 Edit=�6.   $��15q�6:   �� 5H      -   5        $"��Редактирование��5H      #��[  6K   $��Center=�6�   5I      5J      �� 5K      $��1q�6   .��5L      �� $ 
Horizontal=�6   .+�5M        $ Delete=�6.   $��15q�6<   �� 5N      -	   5        $��Удаление��5N      #��[  6E   $��Center=�6�   5O      5P      �� 5Q      $��1q�6   .��5R      �� $ 
Horizontal=�6   .+�5S        $ 	ArrowBack=�6.   $��15q�6?   �� 5T      -
   5        $��
Назад��5T      #��[  6<   $��Center=�6x   5U      5V      �� 5W      $��1q�6   .��5X      �� $ 
Horizontal=�6   .+�5Y        $	 Add=�6.   $��15q�69   �� 5Z      -   5        $��btnOpenFile��5Z   <   $-��'добавить изоброжение��6   #��[  6i   $��Center=�6�   5[      5\      5^      5a      5b      