   M S B A M L   `   `   `  ����J  FAIC_LAB5.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AIC_LAB5.Client.MVVM.ViewAIC_LAB5.Client.MVVM.View  5      +    %AIC_LAB5.Client.MVVM.View.StudentView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      9local'clr-namespace:AIC_LAB5.Client.MVVM.View     5      .��5	      � 
�������  � ColumnDefinitions  5
   
   �� 5      $
��0.7* �6   �� 5      $
��0.3* �6   .+�5   
   � .+�5      �� $��5 5 0 5q�6    �� CornerRadius$ 10��6&   
�������._�5      �� $��1��6   $��10q�6n   ��6(   �� *
Students+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6z   �� *SelectedStudent+ �� Mode$ OneWayToSource=���5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$ Stretch=�6K   �� 5       � ��$
 auto��66   5       �� View 5      �� 5      .P�5      �� $��Имя��6-   	 �� CellTemplate	 5   "   �� 5   &   .R�5   *   �� $��Center=�64   ��6Q   �� *Name+5   '   5!      �� 5"      $��Группа��6-   	 5#   "   �� 5$   &   .R�5%   *   �� $��Center=�64   ��6Q   �� *Group+5&   '   5(      �� 5)      $ ��Специальность��6-   	 5*   &   �� 5+   *   .R�5,   .   �� $��Center=�68   ��6U   �� *
Speciality+5-   +   5/   #   50      52      53      54      � 57   
   $��1��6   .+�58      �� $��5q�6   
�������$ 10��68   ._�59      �� 
 �� Orientation$
 Vertical=�6   $��Center=�64   .+�5>      � $��5 50 5 0q�6   .+�5?      �� 
���   �$��2q�65   $ 5��6I   ._�5A      �� $
 Vertical=�6%   $��5q�6<   .+�5D      �� $"��Форма студента:��6(   $��16(�5E   (   $
��Bold"�5F   (   � 5I      $	��0 5q�6#   .+�5J   "   �� .+�5K   &   �� $��Имя студента: ��60   �� 5L   *   ��62   �� *StudentForm.Name+$ TwoWay=�$ PropertyChanged=�5M   #   5N      � 5Q      $	��0 5q�6#   .+�5R   "   �� .+�5S   &   �� $%��Группа студента: ��60   �� 5T   *   ��62   �� *StudentForm.Group+$ TwoWay=�$ PropertyChanged=�5U   '   5V      � 5Y      $	��0 5q�6#   .+�5Z   "   �� .+�5[   &   �� $3��-Специальность студента: ��60   �� 5\   *   ��62   �� *StudentForm.Speciality+$ TwoWay=�$ PropertyChanged=�5]   '   5^      5`      5b      5c      � 5h      $
��5 20q�6   .+�5i      �� 
���   �$��2q�65   $ 5��6I   ._�5j      �� $��5q�6)   .+�5k   "   �� $��20��6)   $��Добавить��65   ��6H   �� *CreateStudent+�� 5l   "   $��20��6)   $��Обновить��65   $	��0 5q�6H   ��6U   �� *UpdateStudent+�� 5m   "   $��20��6)   $��Удалить��65   ��6G   �� *DeleteStudent+5n      5o      5p      5q      5r      5s      5t      5u      