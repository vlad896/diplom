   M S B A M L   `   `   `  ����C  ?WpfApp25, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp25WpfApp25  5          WpfApp25.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _MahApps.Metro.IconPacks.Core, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=3.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5      $localclr-namespace:WpfApp25   5      V RMaterialDesignThemes.Wpf, Version=3.1.0.1244, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      :md1http://materialdesigninxaml.net/winfx/xaml/themes  5
      -   5          � Title$  
MainWindow��5      $	��380��5      $	��450��5       � AllowsTransparency . 
������  � 
ResizeMode$ NoResize=�5       � WindowStartupLocation$ CenterScreen=�5       � WindowStyle$
 None=�5      .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      �� $��2��6    �� CornerRadius$ 10��6&   ��5      �� 5      .��5      �  � Offset$	 0.0Q�6'    � Color$ #7be9f6��64   � 5      $ 1Q�6'   $ #f083da��62   5       5"      �� 5#      -   5        $
��Left=�5$      $	��Top=�5%      
������ $��0q�5'      $��Light"�5)      
���   �.��5*   $   
Назад5,      �� 5-      -   5        $	��7,5q�5.      $��Right=�5/      $	��Top=�50      	 � Cursor$
	 Hand��51      $��	helvetica)�52      $��15(�53      
���   �x57      �� 58      $��Center=�6   .+�59      �� $	��200��6   $��Photo/MHM.png��6$   �� 5:      $��Center=�5;      $��	helvetica)�5<      $��22(�5=      $��Light"�5>      
�������$��Minsk Half Marathon��5@      5A      �� 5B      $��1��6   .+�5C      �� 
 �� Orientation$
 
Horizontal=�6   .+�5D      �� -   5         ��Name$ EmailTextbox��5E      $	��235��5F      $��63,0,0,0q�5G      $��Center=�5H      $
��Left=�5I      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Email��5J      $��	Helvetica)�5K      $��17(�5L      $��Light"�5M      
���   � %  !MaterialDesignFloatingHintTextBox#��[  5O      .  (MahApps.Metro.IconPacks.PackIconMaterial  5P      $��Center=�5Q      $��Center=�5R      
�������   Kind$ Account=�5T      5U      �� 5V      $��0,20,0,0q�6   $
 
Horizontal=�6/   .+�5W      �  � ColumnDefinitions 5X      �� 5Y      $��* �6/   �� 5Z      $��* �6/   .+�5\      G� -   5         G�Name$
 pass��5]      $��1��5^      $��63,0,0,0q�5_      $
��Left=�5`      $ Пароль��5a      $��	Helvetica)�5b      $��17(�5c      
���   � ) %MaterialDesignFloatingHintPasswordBox#��[ 5e      �� 5f      -   5        $
 text��5g      $	��235��5h      $��40��5i      $��63,0,0,0q�5j      $��Center=�5k      $
��Left=�5l      $��Bottom=�5m      
������ $��	Helvetica)�5o      $��17(�5p      
���   � �� 
IsReadOnly . $y�Hidden=�5s        5t      -   5        $��1��5u      $��20��5v      $��30��5w      $��Center=�5x      $��Bottom=�5y      $
	 Hand��5z      
�������$ TextboxPassword=�5|      5}      5~      5      �� 5�      -   5         ��Name$ TextBlockReg��5�      $��0,7,65,0q�5�      $��Right=�5�      $
	 Hand��5�      $��	Helvetica)�5�      $��12(�5�      $��Light"�5�      
�������$"У Вас есть аккаунт?5�      �� 5�      $��0,40,0,0q�6   $
 
Horizontal=�6/   .+�5�      �� -	   5         ��Name$ ButtonLogin��5�      $	��100��5�      $��40��5�      $��	60,0,60,0q�5�      $��
Войти��5�      �� 5�      -
   5        $ 	RegButton��5�      $	��100��5�      $��40��5�      $*��$Зарегистрироваться��5�      5�      5�      5�      5�      5�      