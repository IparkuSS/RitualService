   M S B A M L   `   `   `  ���� J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices      FuneralServices.AddWork   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:FuneralServices     b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes    � Title$)  #Добавление рабочих��$	��525��$��643.5��
������ .��� $��
0,0,-92,-1q� � RowDefinitions �� $	��498 �.+���  �� CornerRadius$ 10��$��0,0,91,0q����� .���  � Color$ #0B270B�� � Offset$	 0.1Q�� $ #F6C900��$ 1Q��� $��30(�$
��bold"����#F6E68C$��Center=�$��154,0,104,455q�$	��436���� $)�#Добавление рабочих���� &   System.Windows.Controls.DataGrid  -     Name$ GridTwo��   AutoGenerateColumns .  $��10(�$��
0,48,91,65q�$
��Bold"�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� $ 	#FF767C00��$ 0.704Q�� $ 	#FFBBCB20��$
 0.17Q�� $ 	#FFB6C81E��$ 0.396Q�	   Columns	 0  *System.Windows.Controls.DataGridTextColumn  
   FontSize$
 10Q�,  &System.Windows.Controls.DataGridColumn   
IsReadOnly .    Header$ Имя��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 110 1  +System.Windows.Controls.DataGridBoundColumn   Binding ��  �� Path$ 
nameWorker�  $
 10Q� . $ Фамилия��$	 120  �� $ surNameWorker�  $
 10Q� . $ отчество��$	 140  �� $ 
partWorker�  $
 10Q� . $! Номер телефона��$ *  �� $ numberTelWorker��� -   $��Добавить�� �� 	IsDefault . $��424,433,121,3q� &  "MaterialDesignToolForegroundButton#��[  $
��Auto���� $��Отмена�� �� IsCancel . $��30,433,508,3q�#��[  $
��Auto�� J� RenderTransformOrigin$ 0.524,8.481&�