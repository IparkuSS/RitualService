   M S B A M L   `   `   `  ���� J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices      FuneralServices.MenCros   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:FuneralServices     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � Title$+  %Информация о крестаx��$��610.333��$��942.5��
������  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� $��0,0,-102,-21q�����  � RowDefinitions �� $	��498 �.+���  �� CornerRadius$ 10��$��3,0,100,-83q����� .���  � Color$ 	#FF8B117A�� � Offset$	 0.1Q�� $ 	#FF394F9B��$ 1Q��� $��30(�$
��bold"����#F6E68C$��Center=�$��154,0,104,455q�$	��436���� $+�%Информация о крестаx���� �� $��imag/coffinBla.png��$��702,10,4,334q� J� RenderTransformOrigin$ 0.664,0.083&�&   System.Windows.Controls.DataGrid  -     Name$
 Grid��	   AutoGenerateColumns	 .  $��10(�$��0,49,336,-83q�$
��Bold"�
   CanUserAddRows
 .  ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� $ 	#FF4F2895��$ 0.704Q�� $ 	#FFA92DC5��$
 0.17Q�   Columns 0  *System.Windows.Controls.DataGridTextColumn     FontSize$ 10Q�,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Класс креста��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 140 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ 	classCros�  $ 10Q� . $ Тип креста��$	 130  �� $ typeCros�  $ 10Q� . $, &Количество на складе��$	 160  �� $ 	countSkCr�  $ 10Q� . $ Цена креста��$	 100  �� $ 	solidCros�4  .System.Windows.Controls.DataGridTemplateColumn  $ Кресты��$ * -   Изоброжение��   CellTemplate �� .R���  ��Name$ IВMM��$	��120������ $ imageCrosses��� $��15(�$��702,192,36,-83q�.@��� $��1q�.����  �� Orientation$ 
Horizontal=�.+�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Text=�$��15q��� -    ��Name$ Search��$��Center=�$	��174��$��34���� $��1q�.���� $ 
Horizontal=�.+�  $ 	SearchAdd=�$��15q��� -   $��
Поиск�� &  "MaterialDesignToolForegroundButton#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�  $	 Add=�$��15q��� -   $��Добавление��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�  $
 Edit=�$��15q��� -   $"��Редактирование��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�  $ Delete=�$��15q��� -   $��Удаление��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�  $ 	ArrowBack=�$��15q��� -	   $��
Назад��#��[  $��Center=��� $��1q�.���� $ 
Horizontal=�.+�  $	 Add=�$��15q��� -
   $��btnOpenFile��$-��'Добавить изоброжение��#��[  $��Center=�