   M S B A M L   `   `   `  ���� J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices       FuneralServices.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:FuneralServices     [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  -     � Title$  
MainWindow��$	��450��$	��380�� � AllowsTransparency . 
������  � WindowStyle$
 None=� � 
ResizeMode$ NoResize=� � WindowStartupLocation$ CenterScreen=�.��� .+��  � RowDefinitions �� �� .+���  �� CornerRadius$ 10��$��2������ .���  � Color$ #0B270B�� � Offset$	 0.0Q�� $ #951466��$ 1Q��� $��Center=�.+��� $��imag/coffinBla.png��$	��140��$��150,0q��� $%��Ритульные услуги��$
��Thin"�$��	helvetica)�$��22(����#F62293$��Center=��� $��Авторизация��$
��Thin"�$��	helvetica)�$��22(����#F62293$��Center=��� $��1��.+��� 	 �� Orientation$	 
Horizontal=�.+��� -   
 ��Name$
 	LoginForm��$��	Helvetica)�$��Light"�)  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��$��20(� �� 	MaxLength$ 20��$��Center=�
�������
������ $��0q�$	��235��$
��Left=� J� Opacity$ 1Q�$��33��$��63,0,0,0q�.  (MahApps.Metro.IconPacks.PackIconMaterial  E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $	 
Horizontal=�$��0,20,0,0q�.+�G� -    G�Name$ PassForm��$��	Helvetica)�$��Light"�$ Пароль��$��20(� G� 	MaxLength$ 15��$��Center=�
�������
������ $��0q�$	��235��$
��Left=�$ 1Q�$��35��$��63,0,0,0q�  $ TextboxPassword=�$��Center=�$��Center=�
��������� $	��250��$��2��
�������$	 0.5Q��� $	 
Horizontal=�$��0,50,0,0q�.+��� -   $	��100��$��40��$��
ВОЙТИ��$��	60,0,60,0q� &  "MaterialDesignToolForegroundButton#��[  �� -   $	��130��$��40��$��РЕГИСТРАЦИЯ��#��[  �� -   $��40��$��
Выход��$��	284,0,0,0q�#��[  � -   $��pbStatus�� � Minimum$ 0Q� � Maximum$	 100Q�