   M S B A M L   `   `   `  ����C  ?WpfApp25, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp25WpfApp25  5          WpfApp25.Run_Admin   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      (localclr-namespace:WpfApp25     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=null:md1http://materialdesigninxaml.net/winfx/xaml/themes  5      -   5          � Title$  	Run_Admin��5	      $	��800��5
      $	��800��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      $��2* �6    .+�5      �� $��3��5      $��
0,0,0,16.6q�5       �� CornerRadius$ 10��5      ��5      �� 5      .��5       �  � Offset$	 0.0Q�6'    � Color$ #7be9f6��64   � 5!      $ 1Q�6'   $ #f083da��62   5"      5$      �� 5%      -   5        	 ��Name$	 Logout��5&      $
��Left=�5'      $	��Top=�5(      
������ $��0q�5*      .��5+   &   	Log out5-      �� 5.      -   5        $��30��5/      $��40��50      $��0,5,0,0q�51      $��Right=�52      $	��Top=�53      
 � Cursor$

 Hand��54      $��	helvetica)�55      $��30(�56      
�������x5:      � 5;       5<      �� 5=      �� 5>      $��2* �6$   .+�5@      �� -   5         ��Name$ HalfM��5A      $��265,34,233,25.8q�5B      $��Center=�5C      $��Center=�5D      $��	helvetica)�5E      $��24(�5F      $��Light"�5G      
�������$7��1Управление пользователями��5I      � 5J      $��1��6   .+�5K      �  � ColumnDefinitions 5L      �� 5M      �� 5N      �� 5O      .+�5Q      �� -   5        $		 ADD��5R      $	��250��5S      $��45��5T      $��9,14,8.2,118.6q�5U      $0��*Добавить нового бегуна��5W      $��15(�5X      �� 5Y      -   5        $		 Del��5Z      $��1��5[      $	��250��5\      $��45��5]      $��7.8,14,8.6,118.6q�5^      $6��0Удалить выбранного бегуна��5`      $��15(�5a      �� 5b      -   5         ��Name$ TextboxSeatch��5c      $��1��5d      $��50��5e      $��9.8,118,9.6,9.6q�5f      $��Center=�5g      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$$ Текст для поиска��5h      $��16(�5i      
���   � %  !MaterialDesignFloatingHintTextBox#��[  5k      �� 5l      -   5        $	 Remove��5m      $��2��5n      $	��250��5o      $��45��5p      $��8.4,16,8,116.6q�5q      $6��0Изменить выбранную строку��5s      $��15(�5t      �� 5u      -	   5        $
	 TOP3��5v      $��2��5w      $	��250��5x      $��45��5y      $��8.4,70,8,62.6q�5z      $*��$Топ 3 быстрых бегуна��5|      $��15(�5}      �� 5~      -
   5        $	 Search��5      $��2��5�      $	��250��5�      $��45��5�      $��8.4,123,8,9.6q�5�      $��
Найти��5�      $��15(�5�      �� 5�      -   5         ��Name$ Qualific��5�      $��40��5�      $��8,130,0.2,9.6q�5�      $# Критерии поиска��5�      $��16(�5�      .@�5�      �� Id6,   �� 5�      Email6/   �� 5�      Name6.   �� 5�      	Surname61   �� 5�      BD6,   �� 5�      	Country61   �� 5�      Sex6-   �� 5�      Personal_Record69   5�      	� 5�      -   5         	�Name$ 
EmailCheck��5�      $��	10,70,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Email��5�      	� 5�      -   5        $ 	NameCheck��5�      $��
142,73,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $
��Name��5�      	� 5�      -   5        $ SurnamelCheck��5�      $��142,103,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Surname��5�      	� 5�      -   5        $ SexCheck��5�      $��
10,103,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $	��Sex��5�      �� 5�      -   5        $	 
Filtration��5�      $��1��5�      $	��250��5�      $��45��5�      $��6.8,69,9.6,63.6q�5�      $��
Найти��5�      $��15(�5�      5�      � 5�      $��1��6    5�      �� 5�      �� 5�       5�      �� 5�      �� 5�      �� 5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $
��0.3* �6$   �� 5�      $��3* �6$   .+�5�      � $��0��6   $��0��6$    5�      �� 5�      $
��241* �6+   �� 5�      $
��299* �6+   �� 5�      $
��290* �6+   .+�5�      �� -   5        $ TextBlockCounUsers��5�      $	��187��5�      $��24��5�      $��0,12,0,12.8q�5�      $��	helvetica)�5�      $��20(�5�      $��Light"�5�      
�������$,��&Всего пользователей:��5�      �� 5�      -   5        $ CountsUsers��5�      $��1��5�      $��34��5�      $��36��5�      $��-10,12,0,6.8q�5�      $
��Left=�5�      $��Center=�5�      $��	helvetica)�5�      $��25(�5�      $��Light"�5�      
�������$�� ��5�      �� 5�      -   5        $	 ButtonReset��5�      $��2��5�      $	��250��5�      $��45��5�      $��10,0,0,0q�5�      $��Сбросить��5�      $��15(�5�      5�      � 5�      $��1��6   .+�5�      �� -   5         ��Name$ 
TabControl��5�   !   .@�5�      �� $��Users��6"   .��5�      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5�   !   $��2��5�   !   $��
0,0,0,-0.2q�5�   !      CanUserSortColumns .    
IsReadOnly .    SelectionUnit$ FullRow=�5�   !   5�      �� 5�      $��Event��6"   .��5�        -   5        $ 	dataGrid1��5   !   $��2��5  !   $��
0,0,0,-0.2q�5  !    .  . $ FullRow=�5  !   5     �� 5     $��History��6"   .��5       -   5        $ 	dataGrid2��5	  !   $��2��5
  !   $��
0,0,0,-0.2q�5  !    .  . $ FullRow=�5  !   5     5     5     5     5     5     5     