   M S B A M L   `   `   `  ����C  ?WpfApp25, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp25WpfApp25  5          WpfApp25.RunnerMenu   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      $localclr-namespace:WpfApp25   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      -   5          � Title$  
RunnerMenu��5	      $	��385��5
      $	��555��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      $	��70* �6    �� 5      $	��70* �6    �� 5      $	��18* �6    .+�5      �� $��3��5      $��
0,0,0,16.6q�5       �� CornerRadius$ 10��5      ��5      �� 5       .��5!      �  � Offset$	 0.0Q�6'    � Color$ #7be9f6��64   � 5"      $ 1Q�6'   $ #f083da��62   5#      5%      �� 5&      -   5        	 ��Name$	 Log_outButton��5'      $��	0,0,0,214q�5(      $
��Left=�5)      $��Bottom=�5*      
������ $��1q�5,      
���   �.��5.   $   	Log out50      �� 51      -   5        $��7��52      $��18��53      $��0,2,7,0q�54      $��Right=�55      $	��Top=�56      
 � Cursor$

 Hand��57      $��	helvetica)�58      $��15(�59      
���   �x5=      �� 5>      $	��152��5?      $��	0,36,0,10q�5@      $��Center=�5A      .+�5B      �� $	��200��5C      $��0,-8,0,0q�5D      $��Photo/MHM.png��5E      �� 5F      -   5         ��Name$ HalfM��5G      $��Center=�5H      $��	helvetica)�5I      $��22(�5J      $��Light"�5K      
�������$��Minsk Half Marathon��5M      5N      � 5O      $��1��6    � ColumnDefinitions 5P      �� 5Q      �� 5R       5T      �� 5U      $��60 �6$   �� 5V      $��60 �6$   �� 5W      $��60 �6$   �� 5X      $��60 �6$   .+�5Z      �� -   5        $	 	RegButton��5[      $	��150��5\      $��50��5]      $��0,0,10,0q�5^      $��Right=�5_      .��5a      �� $P��JРегистрация                                 на марафон��6    $
��Wrap=�6^   5b      �� 5c      -   5        $	 
EditButton��5d      $��1��5e      $	��150��5f      $��50��5g      $��10,0,0,0q�5h      $
��Left=�5i      .��5k      �� $6��0Редактировать Ваш профиль��6    $
��Wrap=�6A   5l      �� 5m      -   5        $	 
PrilButton��5n      $��1��5o      $	��150��5p      $��50��5q      $��25,0,0,0q�5r      $��Center=�5s      .��5u      �� $��О приложении��6    $
��Wrap=�64   5v      �� 5x      -   5        $	 Infaboutevent��5y      $��1��5z      $��1��5{      $	��150��5|      $��50��5}      $��10,0,0,0q�5~      $
��Left=�5      ��5�      �� 5�      
�������$4��.Информация о         событии��5�      $
��Wrap=�5�      5�      �� 5�      -	   5        $	 SponsorsButton��5�      $��2��5�      $	��150��5�      $��50��5�      $��25,0,0,0q�5�      $��Center=�5�      .��5�      �� $/��)   Cпонсоры мероприятия��6    $
��Wrap=�6?   5�      �� 5�      -
   5        $	 MyResult��5�      $��2��5�      $��1��5�      $	��150��5�      $��50��5�      $��0,0,25,0q�5�      $��Center=�5�      $!��Мои результаты��5�      �� 5�      -   5        $		 BMR��5�      $��3��5�      $	��150��5�      $��50��5�      $��25,0,0,0q�5�      $��Center=�5�      .��5�      �� $&��       BMR калькулятор��6    $
��Wrap=�6=   5�      �� 5�      -   5        $		 BMI��5�      $��3��5�      $��1��5�      $	��150��5�      $��50��5�      $��0,0,25,0q�5�      $��Center=�5�      .��5�      �� $&��       BMI калькулятор��6    $
��Wrap=�6=   5�      5�      � 5�      $��2��6   $��0,10,0,0q�6    .+�5�      �� $	��Top=�5�      $��Center=�5�      $��	helvetica)�5�      $��13(�5�      $��Light"�5�      
���������5�      �� *Times+ �� UpdateSourceTrigger$ PropertyChanged=� �� Mode$ OneWay=�5�      5�      5�      5�      5�      