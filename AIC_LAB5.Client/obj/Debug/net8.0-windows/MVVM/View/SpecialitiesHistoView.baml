   M S B A M L   `   `   `  ����U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5      J FAIC_LAB5.Client, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:AIC_LAB5.Client.MVVM.ViewAIC_LAB5.Client.MVVM.View 5      5   /AIC_LAB5.Client.MVVM.View.SpecialitiesHistoView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Clc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     5      9local'clr-namespace:AIC_LAB5.Client.MVVM.View     5      .��5      �   � RowDefinitions  5   
   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   � .+�5      �� 
�������._�5      #   LiveCharts.Wpf.CartesianChart  &    LiveCharts.Wpf.Charts.Base.Chart   Series 5      !   LiveCharts.Wpf.ColumnSeries     LiveCharts.Wpf.Series   Title$$ Кол-во студентов��6F      Fill
 �   �   Values 6*   �� *
HistData+6_      AxisX 5         LiveCharts.Wpf.Axis     Title$  Специальности��6"      FontSize$ 14Q�6V      
Foreground
 �   �$��0 5 0 0q�6w   	   Labels	 68   �� *
HistLabels+6w   
   AxisY
 5        $$ Кол-во студентов��6"   $ 14Q�6;   
 �   �$��0 0 5 0q�6\      MinValue$ 0Q�5   Q      LabelFormatter 6"   �� *HistValuesFormatter+   MaxValue 6^   �� *MaxHistYValue+5      5      5       � 5#   
   $��1��6   .+�5$      �� 
�������._�5%      ��  �� Orientation$ 
Horizontal=�6   $��Center=�66   .+�5&      �� $-��'Обновить гистограмму��6   $
��25 5q�6<   $��5q�6J   ��6V   �� *UpdateHistDataCommand+5'      5(      5)      5+      5,      