   M S B A M L   `   `   `  ����B  >Cabinet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:Cabinet.Windows.AppointmentsCabinet.Windows.Appointments  5   	   5    /Cabinet.Windows.Appointments.AppointmentsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:Cabinet.Windows.Appointments     5   	   _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  AppointmentsWindow��5	   	   $	��900��6$   $
��1300��61      MaterialDesignBody#���   5
   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ��5   	   Z� .��5      #  MaterialDesignThemes.Wpf.Card    MaterialDesignPaper#���  6      UniformCornerRadius$ 15Q�6M   $��25q�6f   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6r   .��5   
   �  � ColumnDefinitions 5      �� 5      $	��250 �6#   61   �� 5      $��* �6#   6/   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6'   $	��850��67      CornerRadius$ 	15 0 0 15��6D   
�������.��5      �� $��15q�6   .+�5      � $��	0 10 5 60q�6    $��Center=�63   .+�5      ��  �� BitmapScalingMode$ HighQuality=�6    $��	logo2.png��6N   $	��120��6a   $	��120��6n   6|   5      �� 5        MaterialDesignFlatButton#��[ 6    " PrimaryHueLightForegroundBrush#���  6O   +  %MaterialDesignThemes.Wpf.ButtonAssist	   CornerRadius$	 6��5      $
��auto��6J   $��35��6W   +  %MaterialDesignThemes.Wpf.RippleAssist
   Feedback

 �����$��0 0 0 15q�5       .��5"      � $	��180��6$   .+�5#      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�66   $��Center=�6B   $��0 0 20 0q�6]   6q   �� 5$      	Dashboard63   5%      5&      �� 5(      -   5         ��Name$ patientsBtn��5*   /   #��[ 5(      #���  6O   $	 6��5)      $
��auto��6J   $��35��6W   

 �����$��0 0 0 15q�5*      .��5,      � $	��180��6$   .+�5-        $ Patient=�66   $��Center=�6E   $��0 0 20 0q�6`   6t   �� 5.      
Patients62   5/      50      �� 52      -   5        $ doctorsWindow��54   /   #��[ 52      #���  6O   $	 6��53      $
��auto��6J   $��35��6W   

 �����$��0 0 0 15q�54      .��56      � $	��180��6$   .+�57        $ Doctor=�66   $��Center=�6D   $��0 0 20 0q�6_   6s   �� 58      	Doctors61   59      5:      �� 5<      -   5        $ appointmentsWindow��5>   /   #��[ 5<      #���  6O   $	 6��5=      $
��auto��6J   $��35��6W   

 �����$��0 0 0 15q�5>       ! MaterialDesignFlatButtonClick#��[ 6K   .��5@      � $	��180��6$   .+�5A        $ Clock=�66   $��Center=�6C   $��0 0 20 0q�6^   6r   �� 5B      Appointments66   5C      5D      �� 5F      -   5        $ 	logoutBtn��5H   /   #��[ 5F      #���  6O   $	 6��5G      $
��auto��6J   $��35��6W   

 �����$��0 0 0 15q�5H      .��5J      � $	��180��6$   .+�5K        $ Logout=�66   $��Center=�6D   $��0 0 20 0q�6_   6s   �� 5L      Logout60   5M      5N      5O      5Q      �� 5S      $��1��6   $��	15 0 10 0q�6)    J� OpacityMask 5T      �� 5U       �� EndPoint$ 0.5,1&�6*    �� 
StartPoint$ 0.5,0&�6;   .��5V      �  � Color$ Black��6'    � Offset$ 0Q�65   � 5W      $ 	#FFD6D6D6��6'   $ 1Q�69   5X      .+�5Z      ]� $��	0 20 0 10q�6   .+�5[      �� $��Manage Your Appointments��6    $��20(�6@   $
��Bold"�6N   $��Center=�6`   6}   �� 5\      -   5         ��Name$ 	searchBox��5\      $	��150��61   $��50��6=   
�������$��Right=�6\   $��2q�6x     MaterialDesignDivider#���  6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5]       ! MaterialDesignOutlinedTextBox#��[ 6E   6�   5^      ]� 5`      $��	0 10 0 10q�6   .+�5a      �� -   5        $ 	activeBtn��5b      $��0 0 5 0q�5a      $	��100��6.   $��60��6:   
������ $��1q�6_   
���   �
���   �.��5b   H   Active6P   �� 5c      -   5        $ cancelledBtn��5d      $��0 0 5 0q�5c      $	��100��6.   $��60��6:   
������ $��1q�6_   ���	#FFD6D6D6
���   �.��5d   N   	Cancelled6Y   �� 5e      -   5        $ resolvedBtn��5f      $	��100��5e      $��60��6)   
������ $��1q�6N   ���	#FFD6D6D6
���   �.��5f   L   
Resolved6V   (  "System.Windows.Controls.DatePicker  5g      -	   5          Name$ 	dateInput��5h   k   $��35 0 0 0q�5g   !   $	��300��63   $��60��6?   $��Center=�6K   $��18(�6f   $
 Date��6u    $  MaterialDesignOutlinedDatePicker#��[ 6�   $��2q�5h   !   #���  65   6�   �� 5i      -
   5         ��Name$ doctorsList��5j   i   $��Right=�5i      $	��300��66   $��18(�6B   $ Doctor��6Q    " MaterialDesignOutlinedComboBox#��[ 6y   $��2q�5j      #���  63   6�   �� 5k      6"   5l        5n      
�������$ 5Q�69   $��5q�6Q   .��5q      �� .+�5r      ]� .+�5s      �� $��List of Appointments��6(   $��15(�6D   $��SemiBold"�6R   $��Center=�6h   6�   �� 5t      -   5        $ 	deleteBtn��5t   �   $	��100��6%   
���<��
�������$��0q�6Y   $��Right=�6m   {�.  .��6�   Delete6�   �� 5u      -   5        $ addBtn��5u   �   $	��100��6%   
�������
�������$��0q�6[   $��Right=�6o   $��0 0 20 0q�6�   .��6�   Add6�   �� 5v      -   5        $ 	updateBtn��5v   �   $	��100��6%   
���2�2�
�������$��0q�6[   $��Right=�6o   $��0 0 20 0q�6�   {�.  .��6�   Update6�   �� 5w      6*   5x      &	   System.Windows.Controls.DataGrid	  5z      -   5         	 Name$ appointmentsDataGrid��5{   '    	 MaterialDesignDataGrid#��[	 5z   #    &
 "MaterialDesignDataGridColumnHeader 	  ColumnHeaderStyle# � 
 6S    	  CanUserReorderColumns .  ��. $
��Auto=�5{   �   
������ 
������� 	  AutoGenerateColumns .   	  SelectionMode$ Single=�5|   n    	  Columns 5~      4
  .System.Windows.Controls.DataGridCheckBoxColumn
  5   "   ,  &System.Windows.Controls.DataGridColumn   CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6O      HeaderTemplate 5�   &   �� 5�   *   .R�5�   .   ��    MaterialDesignAccentCheckBox#���  67   6p   5�   +   5�   #   0  *System.Windows.Controls.DataGridTextColumn  5�   "      Header$ Id��65       
IsReadOnly  .  .  $ * 6�   !   
Visibility$! 	Collapsed=�6�   1  +System.Windows.Controls.DataGridBoundColumn"   Binding" 6A   �� *Id+6�     5�   "   $ Doctor��65     .  .  $ * 6�   " 6E   �� *
DoctorUi+6�     5�   "   $ Patient��65     .  .  $ * 6�   " 6F   �� *	PatientUi+6�     5�   "   $
 Date��65     .  .  $ * 6�   " 6C   �� *Date+6�     5�   "   $
 Time��65     .  .  $ * 6�   " 6C   �� *Time+6�   # 	  RowStyle# 5�      �� 5�   "   $ �� 
TargetType)  #System.Windows.Controls.DataGridRow"$  6(     MaterialDesignDataGridRow% �� BasedOn#% [ 6A   & �� Triggers& 5�   &   P� 5�   *   ' P� Property' �@J�IsMouseOver( P� Value( . . �5�   .   �� ) �� Property) � �� , (MaterialDesignDataGridRowHoverBackground* �� Value#* [ 6K   6�   5�   +   5�   #   + 	  	CellStyle+ 5�      �� 5�   "   *  $System.Windows.Controls.DataGridCell"$  6(     MaterialDesignDataGridCell#% [ 6B   & 5�   &   P� 5�   *   ' �@ 
IsSelected( . . �5�   .   �� ) � ��  MaterialDesignBodyLight#* [ 6L   6   �� 5�   .   ) � ��$* 0q�6P   6\   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      