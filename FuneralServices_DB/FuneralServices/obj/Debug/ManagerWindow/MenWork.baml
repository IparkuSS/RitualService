   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	       FuneralServices.MenWork   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � Title$  Рабочие��5
   	   $	��665��6   $	��759��6&   
������  � 
ResizeMode$ NoResize=�6b    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,0,-102,-21q�6    � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��0,0,100,-137q�6#   ��5      �� 5      .��5      �  � Color$ 	#FF8B117A��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF394F9B��6#   $ 1Q�65   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��112,0,128,455q�6g   $	��454��6~   �� 6�   $.�(  Информация о рабочих��6�   �� 6�   6�   �� 5   
   $��imag/coffinBla.png��6   $��588,43,128,293q�6,    J� RenderTransformOrigin$ 0.664,0.083&�6D   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$
 Grid��5   /   	   AutoGenerateColumns	 .  $��10(�6=   $��0,43,297,-137q�6K   $
��Bold"�6b   
   CanUserAddRows
 .  ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � $ 	#FF4F2895��6#   $ 0.704Q�65   � 5      $ 	#FFA92DC5��6#   $
 0.17Q�65   5          Columns 5"      0  *System.Windows.Controls.DataGridTextColumn  5#         FontSize$ 10Q�6L   ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Имя��6l      Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 6y   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ 
nameWorker�6y     5$      $ 10Q�6N    . $ Фамилия��6n   $	 120 6    6%   �� $ surNameWorker�6     5%      $ 10Q�6K    . $ отчество��6k   $	 140 6}    6%   �� $ 
partWorker�6}     5&      $ 10Q�6P    . $! Номер телефона��6p   $ * 6�    6%   �� $ numberTelWorker�6�   5)      �� 5*   
   $��15(�6   $��551,312,36,-126q�6!   .@�5+      �� $��1q�6   .��5,      ��  �� Orientation$ 
Horizontal=�6   .+�5-      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�6.   $��15q�6:   �� 5.      -   5         ��Name$ Search��5.   9   $��Center=�6   $	��140��6I   $��34��6U   5/      50      �� 51      $��1q�6   .��52      �� $ 
Horizontal=�6   .+�53        $ 	SearchAdd=�6.   $��15q�6?   �� 54      -   5        $��
Поиск��54       &  "MaterialDesignToolForegroundButton#��[  6B   $��Center=�6~   55      56      �� 57      $��1q�6   .��58      �� $ 
Horizontal=�6   .+�59        $	 Add=�6.   $��15q�69   �� 5:      -   5        $��Добовление��5:      #��[  6E   $��Center=�6�   5;      5<      �� 5>      $��1q�6   .��5?      �� $ 
Horizontal=�6   .+�5@        $
 Edit=�6.   $��15q�6:   �� 5A      -   5        $"��Редактирование��5A      #��[  6K   $��Center=�6�   5B      5C      �� 5D      $��1q�6   .��5E      �� $ 
Horizontal=�6   .+�5F        $ Delete=�6.   $��15q�6<   �� 5G      -   5        $��Удаление��5G      #��[  6E   $��Center=�6�   5H      5I      �� 5J      $��1q�6   .��5K      �� $ 
Horizontal=�6   .+�5L        $ 	ArrowBack=�6.   $��15q�6?   �� 5M      -   5        $��
Назад��5M      #��[  6<   $��Center=�6x   5N      5O      5P      5S      5T      