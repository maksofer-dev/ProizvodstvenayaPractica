   M S B A M L   `   `   `  ����i  eИС агенства недвижимости, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Jclr-namespace:ИС_агенства_недвижимости.View.MainView<ИС_агенства_недвижимости.View.MainView  5   	   N    HИС_агенства_недвижимости.View.MainView.AddRentInfo   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :d2http://schemas.microsoft.com/expression/blend/2008  5   	   Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5   	   VlocalJclr-namespace:ИС_агенства_недвижимости.View.MainView  5   	     � Title$  AddRentInfo��5	   	   $��611.5��6   $	��661��6,    � AllowsTransparency . 
������  � WindowStartupLocation$ CenterScreen=�6k    � WindowStyle$
 None=�6�    � 
ResizeMode$ NoResize=�6�   .��5
      � .+�5   
   ��  �� CornerRadius$ 10��6   ��5      �� 5      .��5      �  � Color$ 	#FF5C7E95��6#    � Offset$	 0.0Q�65   � 5      $ Black��6#   $ 1Q�61   5      ._�5      �� .+�5      �� $(��"Заполните все поля��6   $��Center=�66   $��Center=�6S   $��34(�6n   
�������$R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6�   $��0,50,0,0q�6�   �� 5      -   5         ��Name$ fioBox��5      )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 ФИО��6*   $��Center=�6O   $��Center=�6l   $��24(�6�   $��40��6�   $	��400��6�   $��0,90,0,0q�6�   
�������$R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6�   �� 5      
 �� Orientation$
 
Horizontal=�6   $��Center=�66   $��Center=�6S   $��0,30,0,0q�6n   .+�5      �� -   5        $ 
addressBox��5      $	 
Адрес��62   $��24(�6Y   $	��200��6g   $��Center=�6s   $��Center=�6�   $��
0,0,10.1,0q�6�   
�������$R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6�   �� 5      -   5        $ telBox��5      $	 Телефон��6.   $��24(�6W   $	��200��6e   $��Center=�6q   $��Center=�6�   
�������$R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6�   �� 5      -   5        $ costBox��5      $	 Стоимость��6/   $��24(�6Z   $��Center=�6h   $��Center=�6�   $	��150��6�   
�������$��0q�6�   $R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6�   5      �� 5      $
 
Horizontal=�6   $��Center=�66   $��Center=�6S   $��0,30,0,0q�6n   .+�5      �� -   5        $ etajBox��5      $	 Этажность��6/   $��24(�6Z   $	��200��6h   $��Center=�6t   $��Center=�6�   $��
0,0,10.1,0q�6�   
�������$R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6�   �� 5      -   5        $ plosBox��5      $	 Площадь��6/   $��24(�6X   $	��200��6f   $��Center=�6r   $��Center=�6�   
�������$R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6�   �� 5      -   5        $ kolvoBox��5      $	 Кол-во комнат��60   $��24(�6_   $	��200��6m   $��Center=�6y   $��Center=�6�   
�������$��10,0,0,0q�6�   $R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6�   5!      �� 5%      -   5         ��Name$ clipImageBN��5%      $��50��6.   $	��210��6:   $1��+Прикрепить изображение��6F   $��225,50,225,0q�6   $��Center=�6�   $��Center=�6�   $R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6�   �� 5&      $
 
Horizontal=�6   $��Center=�66   $��Center=�6S   $��0,15,0,0q�6n   .+�5'      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	Paperclip=�6.   ���	#FFF3F3F36?   �� 5(      -	   5         ��Name$ clipPathLBL��5(      ���	#DDFFFFFF��61   Z� 6G   5)      �� 5*      $
 
Horizontal=�6   $��Center=�66   $��Center=�6S   $��0,20,0,0q�6n   .+�5+      �� -
   5        $ addBN��5+      $��50��6,   $	��150��68   $��Добавить��6D   $��0,0,20,0q�6W   $��18(�6i   $R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6w   6�   �� 5,      -   5        $ cancelBN��5,      $��50��6/   $	��150��6;   $��Отмена��6G   $��20,0,0,0q�6X   $��18(�6j   $R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6x   6�   5.      5/      51      53      54      