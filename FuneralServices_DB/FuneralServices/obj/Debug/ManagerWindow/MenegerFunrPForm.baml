   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	   &     FuneralServices.MenegerFunrPForm   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � Title$  Похороны��5
   	   $	��583��6   $	��678��6'   
������  � 
ResizeMode$ NoResize=�6M    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,0,-102,-21q�6    � ColumnDefinitions 5   
   �� 5      ��5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��0,0,102,-55q�6#   ��5      �� 5      .��5      �  � Color$ 	#FF8B117A��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF394F9B��6#   $ 1Q�65   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��150,0,144,455q�6g   $	��480��6~   �� 6�   $0�*Информация о похоронах��6�   �� 6�   6�   �� 5    
   $��imag/coffinBla.png��6   $��436,30,25,351q�6,    J� RenderTransformOrigin$ 0.664,0.083&�6C   &   System.Windows.Controls.DataGrid  5!   
   -   5        	  Name$
	 Grid��5!   /   
   AutoGenerateColumns
 .  $��10(�6=   $��
0,43,0,-55q�6K   $
��Bold"�6_   $
��Left=�6q   $	��413��6�      CanUserAddRows .  ��5"      �� 5#       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5$      � $ 	#FF4F2895��6#   $ 0.704Q�65   � 5%      $ 	#FFA92DC5��6#   $
 0.17Q�65   5&         Columns 5(      4  .System.Windows.Controls.DataGridTemplateColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Дата похорон��6)   -   5        TwoDatColumns��   CellTemplate 5+      �� 5,      .R�5-      ��  ��Name$ myCmbForCofs��6'   -   5         �� SelectedItem 5-   �   �� *OrderFunDate+ �� Mode$ TwoWay=�5.      50      0  *System.Windows.Controls.DataGridTextColumn  51         FontSize$ 10Q�6U      
IsReadOnly . $ Рабочие��6u      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$ OrderFSurNameWorker�6�     52      $ Время похорон��6)   -   5        TwoDatColumnDat�� .  53      �� 54      .R�55      )  #MaterialDesignThemes.Wpf.TimePicker  -   5         � Language$ ru-ru�55   Z   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Время начала��6m      SelectedTime 69   �� *	timeFun+6�   56      58      5;      �� 5<   
   $��15(�6   $��413,178,177,-54q�6!   .@�5=      �� $��1q�6   .��5>      ��  �� Orientation$ 
Horizontal=�6   .+�5?      '	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$
 Text=�6.   $��15q�6:   �� 5@      -   5         ��Name$ Search��5@   9   $��Center=�6   $	��114��6I   $��34��6U   5A      5B      �� 5C      $��1q�6   .��5D      �� $ 
Horizontal=�6   .+�5E      	  $ 	SearchAdd=�6.   $��15q�6?   �� 5F      -   5        $��
Поиск��5F       &  "MaterialDesignToolForegroundButton#��[  6B   $��Center=�6~   5G      5H      �� 5I      $��1q�6   .��5J      �� $ 
Horizontal=�6   .+�5K      	  $	 Add=�6.   $��15q�69   �� 5L      -   5        $��Добовление��5L      #��[  6E   $��Center=�6�   5M      5N      �� 5O      $��1q�6   .��5P      �� $ 
Horizontal=�6   .+�5Q      	  $	 Add=�6.   $��15q�69   �� 5R      -	   5        $��Рабочие��5R      #��[  6A   $��Center=�6}   5S      5T      �� 5U      $��1q�6   .��5V      �� $ 
Horizontal=�6   .+�5W      	  $ Delete=�6.   $��15q�6<   �� 5X      -
   5        $��Удаление��5X      #��[  6E   $��Center=�6�   5Y      5Z      �� 5[      $��1q�6   .��5\      �� $ 
Horizontal=�6   .+�5]      	  $ 	ArrowBack=�6.   $��15q�6?   �� 5^      -   5        $��
Назад��5^      #��[  6<   $��Center=�6x   5_      5`      5a      5b      5c      