   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	   %    FuneralServices.MenegerCustomer   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	        � Title$  Заказчик��5
   	   $	��583��6   $	��799��6'   
������  � 
ResizeMode$ NoResize=�6N    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��0,0,-102,-21q�6    � ColumnDefinitions 5   
   �� 5      $
��685* �6   �� 5      $
��209* �6   ��5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��498 �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��3,0,102,-55q�6#   $��2��68   ��5      �� 5      .��5      �  � Color$ 	#FF8B117A��6#    � Offset$	 0.1Q�65   � 5      $ 	#FF394F9B��6#   $ 1Q�65   5      5      �� 5   
   $��30(�6   $
��bold"�6"   ���#F6E68C$��Center=�6J   $��193,0,204,455q�6g   $	��497��6~   $��2��6�   �� 6�   $0�*Информация о заказчике��6�   �� 6�   6�   �� 5    
   $��imag/coffinBla.png��6   $��612,10,53,343q�6,    J� RenderTransformOrigin$ 0.664,0.083&�6C   $��2��6g   &   System.Windows.Controls.DataGrid  5!   
   -   5        	  Name$
	 Grid��5!   /   
   AutoGenerateColumns
 .  $��10(�6=   $��0,43,161,-55q�6K   $
��Bold"�6a      CanUserAddRows .  ��5"      �� 5#       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5%      � $ 	#FF4F2895��6#   $ 0.704Q�65   � 5&      $ 	#FFA92DC5��6#   $
 0.17Q�65   5'         Columns 5*      0  *System.Windows.Controls.DataGridTextColumn  5+         FontSize$ 10Q�6F   ,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Имя��6f      Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6s   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   ��  �� Path$
 name�6s     5,      $ 10Q�6H    . $ Фамилия��6h   $ 90 6y    6%   �� $ surName�6y     5-      $ 10Q�6E    . $ Отчество��6e   $	 100 6w    6%   �� $
 part�6w     5.      $ 10Q�6G    . $ 
Адрес��6g   $ 90 6v    6%   �� $ addres�6v     5/      $ 10Q�6L    . $! Номер телефона��6l   $ * 6�    6%   �� $ phoneNumber�6�   51      �� 55   
   $��15(�6   $��556,218,102,-54q�6!   $��2��6:   .@�56      �� $��1q�6   .��57      ��  �� Orientation$ 
Horizontal=�6   .+�58      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�6.   $��15q�6:   �� 59      -   5         ��Name$ Search��59   9   $��Center=�6   $	��174��6I   $��34��6U   5:      5;      �� 5<      $��1q�6   .��5=      �� $ 
Horizontal=�6   .+�5>        $ 	SearchAdd=�6.   $��15q�6?   �� 5?      -   5        $��
Поиск��5?       &  "MaterialDesignToolForegroundButton#��[  6B   $��Center=�6~   5@      5A      �� 5B      $��1q�6   .��5C      �� $ 
Horizontal=�6   .+�5D        $	 Add=�6.   $��15q�69   �� 5E      -   5        $��Добовление��5E      #��[  6E   $��Center=�6�   5F      5G      �� 5I      $��1q�6   .��5J      �� $ 
Horizontal=�6   .+�5K        $
 Edit=�6.   $��15q�6:   �� 5L      -   5        $"��Редактирование��5L      #��[  6K   $��Center=�6�   5M      5N      �� 5O      $��1q�6   .��5P      �� $ 
Horizontal=�6   .+�5Q        $ Delete=�6.   $��15q�6<   �� 5R      -   5        $��Удаление��5R      #��[  6E   $��Center=�6�   5S      5T      �� 5U      $��1q�6   .��5V      �� $ 
Horizontal=�6   .+�5W        $ 	ArrowBack=�6.   $��15q�6?   �� 5X      -   5        $��
Назад��5X      #��[  6<   $��Center=�6x   5Y      5Z      5[      5^      5_      