   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	        FuneralServices.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   
   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   -   5          � Title$  
MainWindow��5
   	   $	��450��6   $	��380��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ #0B270B��6'    � Offset$	 0.0Q�67   � 5      $ #951466��6'   $ 1Q�67   5      5      �� 5      $��Center=�6   .+�5      �� $��imag/coffinBla.png��6   $	��140��64   $��150,0q�6A   �� 5      $%��Ритульные услуги��6   $
��Thin"�5      $��	helvetica)�5       $��22(�5!      ���#F62293$��Center=�5#      �� 5$      $��Авторизация��6   $
��Thin"�5%      $��	helvetica)�5&      $��22(�5'      ���#F62293$��Center=�5)      5*      �� 5+      $��1��6   .+�5,      �� 	 �� Orientation$	 
Horizontal=�6   .+�5-      �� -   5        
 ��Name$
 	LoginForm��51      $��	Helvetica)�5-      $��Light"�5.      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 
Логин��5/      $��20(�50       �� 	MaxLength$ 20��52      $��Center=�53      
�������
������ $��0q�56      $	��235��57      $
��Left=�58       J� Opacity$ 1Q�59      $��33��5:      $��63,0,0,0q�5;      .  (MahApps.Metro.IconPacks.PackIconMaterial  5<      E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=�61   $��Center=�5=   1   $��Center=�5>   1   
�������5?   1   5@      �� 5A      $	��250��6   $��2��5B      
�������$	 0.5Q�5D      �� 5H      $	 
Horizontal=�6   $��0,20,0,0q�66   .+�5I      G� -   5         G�Name$ PassForm��5K      $��	Helvetica)�5I   "   $��Light"�5J      $ Пароль��5L      $��20(�5M       G� 	MaxLength$ 15��5N      $��Center=�5O      
�������
������ $��0q�5R      $	��235��5S      $
��Left=�5T      $ 1Q�5U      $��35��5V      $��63,0,0,0q�5W        5X      $ TextboxPassword=�61   $��Center=�5Y   1   $��Center=�5Z   1   
�������5[   1   5\      �� 5]      $	��250��6   $��2��5^      
�������$	 0.5Q�5`      �� 5c      $	 
Horizontal=�6   $��0,50,0,0q�66   .+�5e      �� -   5        $	��100��5e      $��40��6)   $��
ВОЙТИ��65   $��	60,0,60,0q�6E    &  "MaterialDesignToolForegroundButton#��[  6k   �� 5f      -   5        $	��130��5f      $��40��6)   $��РЕГИСТРАЦИЯ��6E   #��[  6[   5g      �� 5h      -   5        $��40��5h      $��
Выход��6%   $��	284,0,0,0q�65   #��[  6Y   � 5i      -   5        $��pbStatus��5i   8    � Minimum$ 0Q�6    � Maximum$	 100Q�6*   68   5j      5k      5l      5m      