   M S B A M L   `   `   `  ���� J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  &     FuneralServices.MenegerFunrPForm   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:FuneralServices     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Похороны��$	��583��$	��678��
������  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� $��0,0,-102,-21q� � ColumnDefinitions �� ����  � RowDefinitions �� $	��498 �.+���  �� CornerRadius$ 10��$��0,0,102,-55q����� .���  � Color$ 	#FF8B117A�� � Offset$	 0.1Q�� $ 	#FF394F9B��$ 1Q��� $��30(�$
��bold"����#F6E68C$��Center=�$��150,0,144,455q�$	��480���� $0�*Информация о похоронах���� �� $��imag/coffinBla.png��$��436,30,25,351q� J� RenderTransformOrigin$ 0.664,0.083&�&   System.Windows.Controls.DataGrid  -   	  Name$
	 Grid��
   AutoGenerateColumns
 .  $��10(�$��
0,43,0,-55q�$
��Bold"�$
��Left=�$	��413��   CanUserAddRows .  ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� $ 	#FF4F2895��$ 0.704Q�� $ 	#FFA92DC5��$
 0.17Q�   Columns 4  .System.Windows.Controls.DataGridTemplateColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Дата похорон��-   TwoDatColumns��   CellTemplate �� .R���  ��Name$ myCmbForCofs��-    �� SelectedItem �� *OrderFunDate+ �� Mode$ TwoWay=�0  *System.Windows.Controls.DataGridTextColumn     FontSize$ 10Q�   
IsReadOnly . $ Рабочие��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ OrderFSurNameWorker�  $ Время похорон��-   TwoDatColumnDat�� .  �� .R�)  #MaterialDesignThemes.Wpf.TimePicker  -    � Language$ ru-ru�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Время начала��   SelectedTime �� *	timeFun+�� $��15(�$��413,178,177,-54q�.@��� $��1q�.����  �� Orientation$ 
Horizontal=�.+�'	  !MaterialDesignThemes.Wpf.PackIcon	   	  Kind$
 Text=�$��15q��� -    ��Name$ Search��$��Center=�$	��114��$��34���� $��1q�.���� $ 
Horizontal=�.+�	  $ 	SearchAdd=�$��15q��� -   $��
Поиск�� &  "MaterialDesignToolForegroundButton#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�	  $	 Add=�$��15q��� -   $��Добовление��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�	  $	 Add=�$��15q��� -	   $��Рабочие��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�	  $ Delete=�$��15q��� -
   $��Удаление��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�	  $ 	ArrowBack=�$��15q��� -   $��
Назад��#��[  $��Center=�