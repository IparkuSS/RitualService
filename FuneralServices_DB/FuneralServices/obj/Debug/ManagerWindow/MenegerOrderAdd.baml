   M S B A M L   `   `   `  ����J  FFuneralServices, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:FuneralServicesFuneralServices  5   	   %    FuneralServices.MenegerOrderAdd   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:FuneralServices     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   
     � Title$  
Заказ��5
   	   $��516.185��6   $��533.146��6(   
���   � � 
ResizeMode$ NoResize=�6K    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      � 
���   �$��0,0,0,1q�6   $	��900��6/   $	��500��6<   .+�5   
   �� $	��200��6   $��
10,55,20,0q�6     �� Padding$ 30q�64   $	��800��6A    �� CornerRadius$ 20��6Q   $	��352��6c   $	��Top=�6p   ��5      �� 5      	 �� EndPoint$	 0.5,1&�6&   
 �� 
StartPoint$
 0.5,0&�67   .��5      �  � Color$ 	#FF38B438��6#    � Offset$ 0Q�65   � 5      $ 	#FFC72F2F��6#   $ 1Q�65   5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 30Q�6#      Color$ Yellow��63      ShadowDepth$ 10Q�6B   ._�5      �� $��	0,0,0,-30q�6   .+�5       �� $��
Заказ��6   $��30(�6)   $
��bold"�67   $��	0 0 0 20 q�6I   �� 5!      -   5         ��Name$
 floO��5!   0    �� 	MaxLength$ 3��6>   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$, &Введите пол умершего��6L    %  !MaterialDesignFloatingHintTextBox#��[  6�   ��6   �� *flo+6�   �� 5"      -   5        $ adressO��5"   3   $ 40��6D   $0 *Введите адрес кладбища��6S   #��[  6�   ��6   �� *adress+6�   �� 5#      -   5        $ 	SolidKopO��5#   5   $ 6��6H   $- 'Введите цену за копку��6V   #��[  6�   ��6   �� *
SolidKop+6�   �� 5$      -   5         ��Name$
 Comb��5$   >   $��20(�5&      $* $Выберите вид похрон��5(       J� Opacity$ 1Q�5)      $��41��5*      $��	0,0,187,0q�5+       �� SelectedItem 5$      �� *
viewFunr+5+      � 5,      $��0 0 0 20q�6   $	��108��6)   .+�5.      �� -   5        $
��ОК��5.       �� 	IsDefault . $��
0,27,282,0q�6P    ! MaterialDesignFlatMidBgButton#��[ 6d   $��30��6�   $	��Top=�6�   �� 5/      $��Отмена��6    �� IsCancel . $��250,27,0,51q�6?   #��[ 6T   $
��Auto��6�   50      51      52      53      54      