   M S B A M L   `   `   `  ���� J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  %    FuneralServices.MenMonumentForm   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:FuneralServices     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � Title$0  *Информация о памятиках��$	��583��$��581.5��
������  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� $��0,0,-102,-21q� � ColumnDefinitions �� $
��499* ��� $
��152* �����  � RowDefinitions �� $	��498 �.+���  �� CornerRadius$ 10��$��
3,0,96,-55q�$��2������ .���  � Color$ 	#FF8B117A�� � Offset$	 0.1Q�� $ 	#FF394F9B��$ 1Q��� $��30(�$
��bold"����#F6E68C$��Center=�$��71,0,82,455q�$	��497��$��2���� $2�,Информация о памятниках���� �� $��imag/coffinBla.png��$��371,44,102,348q� J� RenderTransformOrigin$ 0.664,0.083&�$��2��&   System.Windows.Controls.DataGrid  -   	  Name$
	 Grid��
   AutoGenerateColumns
 .  $��10(�$��0,43,163,-55q�$
��Bold"�   CanUserAddRows .  ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� $ 	#FF4F2895��$ 0.704Q�� $ 	#FFA92DC5��$
 0.17Q�   Columns 0  *System.Windows.Controls.DataGridTextColumn     FontSize$ 10Q�,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ организация��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ orgMon�  $ 10Q� . $! Номер телефона��$	 140  �� $ numPhon�  $ 10Q� . $ Цена��$ *  �� $ solidMon��� $��15(�$��357,196,96,-54q�$��2��.@��� $��1q�.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�$��15q��� -    ��Name$ Search��$��Center=�$	��163��$��34���� $��1q�.���� $ 
Horizontal=�.+�  $ 	SearchAdd=�$��15q��� -   $��
Поиск�� &  "MaterialDesignToolForegroundButton#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�  $	 Add=�$��15q��� -   $��Добовление��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�  $
 Edit=�$��15q��� -   $"��Редактирование��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�  $ Delete=�$��15q��� -   $��Удаление��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�  $ 	ArrowBack=�$��15q��� -   $��
Назад��#��[  $��Center=�