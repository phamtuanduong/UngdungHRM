   M S B A M L   `   `   `  ����E  AUngdungHRM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:UngdungHRM.DialogHostControlQUngdungHRM.DialogHostControlQ  5      8    2UngdungHRM.DialogHostControlQ.dialogHost_e_QSkills   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:UngdungHRM.DialogHostControlQ     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��30 �6   �� 5      �� 5      .+�5   
   ��  �� CornerRadius$ 10��6    �� Padding$ 10q�6#   ���#F7F6F6$��3��5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 5Q�6#      ShadowDepth$ 1Q�62      	Direction$	 270Q�6B      MaterialDesignShadow   Color# [  6R      Opacity$	 .42Q�6�   	   RenderingBias$	 Performance=�6�   5      �� 5   
   ���#EFEFEF$ 	10 10 0 0��5      ._�5      �� $��THÊM KỸ NĂNG��6   ���	#B2000000$
��Bold"�5   ;   $��10 0 0 0q�5   $   $��Center=�5   $   5      � 5    
   $��	15 0 15 0q�6   $��1��6"     5!      �� 5"      �� 5#      �� 5$      �� 5%      
 � ColumnDefinitions
 5'      �� 5(      $
��Auto �6#   �� 5)      .+�5,      �� $��Kỹ năng *��6   $��Center=�5-      $��0 5 0 0q�5.      $��14(�5/      �� 51      $��Số năm kinh nghiệm *��6   $��Center=�52      $��0 5 0 0q�53      $��14(�54      $��1��55       �� 59      -   5         ��Name$ cbChucVu��5A      $��1��5;      $��0��5<      
�������   MaterialDesignFilledComboBox#��[ 5>      $��1q�5?      $��3 5 3 5q�5@       �� SelectedValuePath$
 Name��5B       �� DisplayMemberPath$
 Name��5C      {�5:      �� *	IsChecked+ �� ElementName$ 	checkEdit�� �� SelectedValue 5D      �� *Skill+ �� Text 5E      �� *Skill+ �� UpdateSourceTrigger$ PropertyChanged=��� 5H      -   5         ��Name$ txtTen��5P       * &MaterialDesignOutlinedTextFieldTextBox#��[ 5H      $��1��5I      $��1��5J      $��39��5K      
�������$��5 15 5 5q�5M       �� AcceptsReturn .  �� TextWrapping$
 Wrap=�5O      ��5Q      �� *YearsOfExperience+$ PropertyChanged=�{�5R      �� *	IsChecked+$ checkAdd��.��6O   5S      5U      �� 5W   
   $��1��6     MaterialDesignDarkSeparator#��[ 6   $	��0 5q�6T   $��2��6a   $	��Top=�6n   �� 5X   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��
10 10 0 10q�5Y      $
��Left=�5Z      .+�5[      �� -   5         ��Name$ 
btnSaveCur��5a       # MaterialDesignFlatLightBgButton#��[ 5[      ���	#FF086912
�������$��0 0 10 0q�5^      $	��120��5_      
������ +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��5c      .��6C   
LƯU LẠI5e      �� 5g      -   5        #��[ 5g      ���	#FF4D4D4D
�������$��0 0 10 0q�5j      $	��120��5k      
������ $ 15��5m      .��5n   /   
HỦY BỎ5p      5q      5r      5s      