   M S B A M L   `   `   `  ����i  eИС агенства недвижимости, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullo<clr-namespace:ИС_агенства_недвижимости.ИС_агенства_недвижимости  5      @    :ИС_агенства_недвижимости.welcomePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Nlocal<clr-namespace:ИС_агенства_недвижимости     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  6<   -   5          N�Name$  welcomePage1��5       N� Title$ welcomePage��5	      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      $	��100 �6   �� 5      $	��450 �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��1,1,1,3q�6    �� CornerRadius$ 10, 10, 0, 0��6+   
���   �$��2��6[   ��5      �� 5      .��5      �  � Color$ 	#FF5C7E95��6#    � Offset$	 0.0Q�65   � 5      $ Black��6#   $	 1.8Q�61   5      ._�5      � .+�5      �� -   5         ��Name$ 	closeButt��5      
������ $��0q�5      $��40��5       
������ $	��Top=�5!   O   $��Right=�6g   ��5"      �� 5#       �� 
TargetType" ��6    .�5$      �� 	 �� Property	 � ��
 �� Value$
 Fonts/#Dosis)�6G   �� 5%      	 � ��
 6;   Z� �� 5&      	 �@�Cursor$

 Hand��67    �� Triggers 5'      P� 5(   "    P� Property �@J�IsMouseOver P� Value . . �5)   &   �� 	 � ��

 ���� 6C   5*   #   5,      ��5.      �� 5/       �� 
TargetType" ��6*   .R�50      �� $��40��6%   $��40��60   #��z��51   !   ._�52   "   �� $��Center=�63   $��Center=�6N   53      54      .��56      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Close=�6.   
�������$��40��6N   $��40��6Y   57      �� 58       �� Orientation$ 
Horizontal=�6   $	��150��66   $��0,0,90,0q�6C   $��Center=�6U   $��Center=�6r   .+�59      �� $2��,/Images/e39a708c6856321fd07d20958c961947.png��6   $��0q�6R   $	��130��6]   �� 5;      $��Center=�6!   $��Center=�6>   $��0q�6Y   .+�5<      �� $1��+Агентство недвижимости��6$   $��70(�6B   $
��Wrap=�6P   $]��W/ИС агенства недвижимости;component/Fonts/#Champagne & Limousines)�6d    �� TextAlignment$ Center=�6�   
�������$��Center=�6�   $	��Top=�6�   �� 5=      $��"Высота"��6$   $��48(�6>   $ Center=�6L   $R��L/ИС агенства недвижимости;component/Fonts/#Gilroy Bold)�6c   ���	#FF73ABDC6�   5@      5B      5C      5D      �� 5E   
   $K��EВыберете просматриваемую информацию.��6   $��Center=�6?   $��Center=�6\   $��1��6w   $��36(�6�   $
��Bold"�6�   $��Segoe UI Black)�6�   ���	#DDFFFFFF$��2��6�   �� 5F   
   -   5        $ realEstateListButt��5F      $��Center=�6-   $	��250��6^   $��2��6k   $��0,0,50,0q�6x   ���	#FF99D9EA$��3q�6�   $��249.8��6�   $��Right=�6�   ��6H   Z� .��5G      �� $��Stretch=�6   $��Stretch=�65   $	��244��6S   .+�5H      �� $��0,10,0,0q�6   $��/Images/Лого.png��6*   $	��140��6D   �� 5I      $
��Wrap=�6   $+��%Список недвижимости��60   $��Center=�6K   $��24(�6f   $ Center=�6t   $
��Bold"�6�   $��Segoe UI Black)�6�   $��0,29,0,0q�6�   
�������6�   5J      5K      �� 5L   
   -   5        $ clientListButt��5L      $��Center=�6)   $	��250��6Z   $��2��6g   $��50,0,0,0q�6t   ���	#FF99D9EA$��3q�6�   $	��250��6�   $��1��6�   $
��Left=�6�   ��6D   Z� .��5M      �� .+�5N      �� $Q��K/images/png-clipart-computer-icons-business-business-peop232le-logo (1).png��6   $	��180��6m   �� 5P      $
��Wrap=�6   $.��(Информация о клиентах��60   $��Center=�6M   $��Segoe UI Black)�6h   $��24(�6�   $ Center=�6�   
�������6�   5R      5T      5V      5W      