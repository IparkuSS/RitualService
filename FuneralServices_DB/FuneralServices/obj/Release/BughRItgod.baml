   M S B A M L   `   `   `  ���� J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices       FuneralServices.BughRItgod   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:FuneralServices     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$  Цены��$��654.993��$��1367.611��
������  � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� $��
0,0,-8,-21q� � ColumnDefinitions �� ����  � RowDefinitions �� $	��498 �.+���  �� CornerRadius$ 10��$��
0,0,8,-130q����� .���  � Color$ 	#FF196A67�� � Offset$	 0.1Q�� $ #F6C900��$ 1Q��� $��30(�$
��bold"����#F6E68C$��Center=�$��642,0,632,455q�$��96���� $�	 Цены���� �� $��30(�$
��bold"����#F6E68C$��Center=�$��10,0,967,455q�$	��393���� $-�' Информацаия о гробах���� �� $��30(�$
��bold"����#F6E68C$��Center=�$��913,0,64,455q�$	��393���� $/�) Информацаия о крестах���� �� $��30(�$
��bold"����#F6E68C$��Center=�$��488,285,488,170q�$	��394���� $-�' Информацаия о венках���� �� $��imag/coffinBla.png��$��442,49,442,319q� J� RenderTransformOrigin$ 0.664,0.083&�&   System.Windows.Controls.DataGrid  -   	  Name$
	 Grid��
   AutoGenerateColumns
 .  $��10(�$��0,43,844,228q�$
��Bold"�   CanUserAddRows .  ����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� $ 	#FFAEBB2A��$ 0.704Q�� $ 	#FFCB8D20��$
 0.17Q�   Columns 0  *System.Windows.Controls.DataGridTextColumn     FontSize$ 10Q�,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$! Материал гроба��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ materCof�  $ 10Q� . $ Класс гроба��$	 130  �� $ classCof�  $ 10Q� . $( "Цена гроба(Бел.руб)��$	 130  �� $ solidCof�  $ 10Q� . $, &Количество на складе��$	 160  �� $ countSk�  -   $	 GridTwo��
 .  $��10(�$��840,43,8,228q�$
��Bold"� .  ���� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFAEBB2A��$ 0.704Q�� $ 	#FFCB8D20��$
 0.17Q�   $ 10Q� . $ Класс креста��$	 140  �� $ 	classCros�  $ 10Q� . $ Тип креста��$	 130  �� $ typeCros�  $ 10Q� . $, &Количество на складе��$	 160  �� $ 	countSkCr�  $ 10Q� . $ Цена креста��$	 100  �� $ 	solidCros�  -   $	 
GridFthree��
 .  $��10(�$��442,336,442,-54q�$
��Bold"� .  ���� $ 0.5,1&�$ 0.5,0&�.��� $ 	#FFAEBB2A��$ 0.704Q�� $ 	#FFCB8D20��$
 0.17Q�   $ 10Q� . $! Название венка��$	 120  �� $ classWre�  $ 10Q� . $ Тип венка��$	 120  �� $ typeWrea�  $ 10Q� . $ Класс венка��$	 150  �� $ typeV�  $ 10Q� . $ Цена��$	 120  �� $ solid�'  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AddThick=�$��1038,285,0,0q�$��24���� -   $��Добавить цену�� &  "MaterialDesignToolForegroundButton#��[  $��Center=�$��199,271,1037,175q�$��53��  $ AddThick=�$��183,285,0,0q�$��24���� -   $��Добавить цену��#��[  $��Center=�$��1054,271,169,175q�$��53��$ 0.211,0.472&�  $ AddThick=�$��619,568,0,-93q�$��24��$ 2.229,0.472&��� -   $��Добавить цену��#��[  $��Center=�$��628,553,595,-107q�$��53��$ 0.211,0.472&�  $ 	ArrowBack=�$��1164,553,0,-78q�$��24��$ 2.229,0.472&��� -   $��
Назад��#��[  $��Center=�$��1185,514,100,-112q�$��97��$ 0.211,0.472&�