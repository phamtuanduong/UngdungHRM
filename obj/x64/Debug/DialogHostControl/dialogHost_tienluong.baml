   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:UngdungHRM.DialogHostControlUngdungHRM.DialogHostControl  5      7    1UngdungHRM.DialogHostControl.dialogHost_tienluong   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:UngdungHRM.DialogHostControl     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	      .��5
      � -   5          �Name$  controlThemTiente��5
      $y�Visible=�6&   $��0��5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      �� 5      .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��3��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R   	   Opacity$		 .42Q�6�   
   RenderingBias$
 Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� $��THÊM LƯƠNG��6   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5   $   $��Center=�5   $   5       � 5"   
   $��	15 0 15 0q�6   $��1��6"    5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      $
��Auto �6     � ColumnDefinitions 5+      �� 5,      $
��Auto �6#   �� 5-      .+�50      �� $��Lương theo công việc��6   $��Center=�51      $��0 5 0 0q�52      $��14(�53      �� 55      $��Thành phần lương *��6   $��Center=�56      $��0 5 0 0q�57      $��14(�58      $��1��59       �� 5;      $��Tần suất thanh toán��6   $��Center=�5<      $��0 5 10 0q�5=      $��14(�5>      $��2��5?       �� 5A      $��Tiền tệ *��6   $��Center=�5B      $��0 5 10 0q�5C      $��14(�5D      $��3��5E       �� 5G      $��Số tiền *��6   $��Center=�5H      $��0 5 10 0q�5I      $��14(�5J      $��4��5K       �� 5M      -   5         ��Name$ txtInfo��5M      $y�	Collapsed=�6)   $��2��5N      $��Center=�5O      $��0 5 10 0q�5P      $��14(�5Q      $��5��5R       �� 5T      -   5         ��Name$ 	cbQuocgia��5\      $��	15 10 0 0q�5T      $��1��5U      $��0��5V      $��39��5W      $
��Left=�5X      $	��220��5Y      
�������$��1q�5[      $��3 15 3 5q�5]       �� DisplayMemberPath$
 Name��5^       �� SelectedValuePath$
 Name��5_       �� SelectedValue 5`      �� *
PayGrade+ �� Text 5b      �� *
PayGrade+ �� UpdateSourceTrigger$ PropertyChanged=�5e      �� 5g       * &MaterialDesignOutlinedTextFieldTextBox#��[ 6   $��1��5h      $��1��5i      
�������$��5 10 0 5q�5k      $	��220��5l      $
��Left=�5n      ��5m      �� *SalaryComponent+$ PropertyChanged=�.��5n   9   5p      �� 5r      -   5        $
 cbTS��5{      $��	15 10 0 0q�5r      $��1��5s       �� 
IsEditable . $��2��5u      $��39��5v      $
��Left=�5w      $	��220��5x      
�������$��1q�5z      $��3 15 3 5q�5|       5}      �� *PayFrequency+$ PropertyChanged=�5�      �� 5�      -   5        $ cbTiente��5�      $��	15 10 0 0q�5�      $��1��5�      $��3��5�      $��39��5�      $
��Left=�5�      $	��220��5�      
�������$��1q�5�      $��3 15 3 5q�5�      $ Currency��5�      $ Currency��5�       5�      �� *
Currency+ 5�      �� *
Currency+$ PropertyChanged=�5�      �� 5�      #��[ 6   $��1��5�      $��4��5�      
�������$��5 10 0 5q�5�      $	��220��5�      $
��Left=�5�      ��5�      �� *Amount+$ PropertyChanged=�.��6S   5�      5�      �� 5�   
   $��1��6     MaterialDesignDarkSeparator#��[ 6   $	��0 5q�6T   $��2��6a   $	��Top=�6n   �� 5�   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��
10 10 0 10q�5�      $
��Left=�5�      .+�5�      �� -   5         ��Name$ 
btnSaveCur��5�       # MaterialDesignFlatLightBgButton#��[ 5�      ���	#FF086912
�������$��0 0 10 0q�5�      $	��120��5�      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5�      .��6C   
LƯU LẠI5�      �� 5�      -   5        #��[ 5�      ���	#FF4D4D4D
�������$��0 0 10 0q�5�      $	��120��5�      
������ $ 15��5�      .��5�   /   
HỦY BỎ5�      5�      5�      5�      