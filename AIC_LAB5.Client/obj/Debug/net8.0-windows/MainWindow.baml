   M S B A M L   `   `   `  ����J  FAIC_LAB5.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:AIC_LAB5.ClientAIC_LAB5.Client  5   	        AIC_LAB5.Client.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:AIC_LAB5.Client     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   ���#252525.��5
      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      �� 
�������._�5      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   $
��10 5q�6Q   .+�5      	� $��Студенты��6"      	NavButton#��[  65   $��16(�6X    d� 	IsChecked$
 TrueY�6f   ��6w   �� *NavigateToStudentsCommand+	� 5      $��График��6"   #��[  63   $��16(�6V   $
��10 0q�6d   ��6r   �� *#!NavigateToSpecialitiesHistCommand+5      5      5      � 5   
   $��1��6   .+�5      �� ��6   �� *(&NavigationService.ActiveViewModel.View+5      5      5      