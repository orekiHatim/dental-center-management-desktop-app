   M S B A M L   `   `   `  ����B  >Cabinet, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Cabinet.WindowsCabinet.Windows  5   	   #    Cabinet.Windows.DoctorsWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   )localclr-namespace:Cabinet.Windows  5   	     � Title$  DoctorsWindow��5	   	   $	��900��6   $
��1300��6,      MaterialDesignBody#���   5
   	    � AllowsTransparency .  � WindowStyle$
 None=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   ��5   	   Z� .��5      #  MaterialDesignThemes.Wpf.Card    MaterialDesignPaper#���  6      UniformCornerRadius$ 15Q�6M   $��25q�6f   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth4=�6r   .��5   
   �  � ColumnDefinitions 5      �� 5      $	��250 �6#   61   �� 5      $��* �6#   6/   .+�5      (  "MaterialDesignThemes.Wpf.ColorZone  $��0��6'   $	��850��67      CornerRadius$ 	15 0 0 15��6D   
�������.��5      �� $��15q�6   .+�5      � $��	0 10 5 60q�6    $��Center=�63   .+�5      ��  �� BitmapScalingMode$ HighQuality=�6    $	��120��6N   $	��120��6[   6i   5      �� 5        MaterialDesignFlatButton#��[ 6    " PrimaryHueLightForegroundBrush#���  6O   +  %MaterialDesignThemes.Wpf.ButtonAssist	   CornerRadius$	 6��5      $
��auto��6J   $��35��6W   +  %MaterialDesignThemes.Wpf.RippleAssist
   Feedback

 �����$��0 0 0 15q�5       .��5"      � $	��180��6$   .+�5#      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Home=�66   $��Center=�6B   $��0 0 20 0q�6]   6q   �� 5$      	Dashboard63   5%      5&      �� 5(      -   5         ��Name$ patientsBtn��5*   /   #��[ 5(      #���  6O   $	 6��5)      $
��auto��6J   $��35��6W   

 �����$��0 0 0 15q�5*      .��5,      � $	��180��6$   .+�5-        $ Patient=�66   $��Center=�6E   $��0 0 20 0q�6`   6t   �� 5.      
Patients62   5/      50      �� 52      #��[ 6   #���  6O   $	 6��53      $
��auto��6J   $��35��6W   

 �����$��0 0 0 15q�54       ! MaterialDesignFlatButtonClick#��[ 6/   .��56      � $	��180��6$   .+�57        $ Doctor=�66   $��Center=�6D   $��0 0 20 0q�6_   6s   �� 58      	Doctors61   59      5:      �� 5<      -   5        $ appointmentsWindow��5>   /   #��[ 5<      #���  6O   $	 6��5=      $
��auto��6J   $��35��6W   

 �����$��0 0 0 15q�5>      .��5@      � $	��180��6$   .+�5A        $ Clock=�66   $��Center=�6C   $��0 0 20 0q�6^   6r   �� 5B      Appointments66   5C      5D      �� 5F      -   5        $ 	logoutBtn��5H   /   #��[ 5F      #���  6O   $	 6��5G      $
��auto��6J   $��35��6W   

 �����$��0 0 0 15q�5H      .��5J      � $	��180��6$   .+�5K        $ Logout=�66   $��Center=�6D   $��0 0 20 0q�6_   6s   �� 5L      Logout60   5M      5N      5O      5Q      �� 5S      $��1��6   $��	15 0 10 0q�6)   .+�5T      ]� $��	0 20 0 10q�6   .+�5U      �� $��Manage Your Doctors��6    $��20(�6;   $
��Bold"�6I   $��Center=�6[   6x   �� 5V      -   5         ��Name$ 	searchBox��5V      $	��150��61   $��50��6=   
�������$��Right=�6\   $��2q�6x     MaterialDesignDivider#���  6�   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Search��5W       ! MaterialDesignOutlinedTextBox#��[ 6E   6�   5X        5Z      
�������$ 5Q�69   $��5q�6Q   .��5]      �� .+�5^      ]� .+�5_      �� $��List of Doctors��6(   $��15(�6?   $��SemiBold"�6M   $��Center=�6c   6�   )  #MaterialDesignThemes.Wpf.DialogHost  5b      #���  68   $��Right=�6n      DialogContent 5c   "   � 5d   &   $	��300��6+   $	��150��67   $��Center=�6D   .+�5e   *   ��  �� Orientation$ 
Horizontal=�65   $��15q�6N   .+�5f   .     $ Delete=�6F     PrimaryHueMidBrush#��[ 6T   $��50��6�   $��50��6�   6�   �� 5g   .   
�������$	��200��6J   $
��15 5q�6V   $
��Wrap=�6d   %#Do you want to delete this patient?5i   /   5k   +   �� 5l   *   $ 
Horizontal=�65   $��Right=�6N   $��Bottom=�6j   $��15q�6�   .+�5m   .   ��    CloseDialogCommand#��Z 65   #���  6w   $��4q�6�   $��Center=�5n   )   .��6D   Cancel5p   /   �� 5q   .   -   5        $ confirmDeleteBtn��5r   D   #��Z 5q   5   #���  6w   $��4q�6�   $��Center=�5r   )   .��6~   Delete5t   /   5u   +   5v   '   .��5y   "   �� -   5        $ 	deleteBtn��5y   �   $	��100��6)   
���<��
�������$��0q�6]   {�.     OpenDialogCommand#��Z 5z   %   .��6f   Delete6n   5|      �� 5      -   5        $ addBtn��5   �   $	��100��6%   
�������
�������$��0q�6[   $��Right=�6o   $��0 0 20 0q�6�   .��6�   Add6�   �� 5�      -   5        $ 	updateBtn��5�   �   $	��100��6%   
���2�2�
�������$��0q�6[   $��Right=�6o   $��0 0 20 0q�6�   {�.  .��6�   Update6�   �� 5�      6*   5�      &	   System.Windows.Controls.DataGrid	  5�      -	   5         	 Name$ doctorsDataGrid��5�   '     MaterialDesignDataGrid#��[ 5�   #    &	 "MaterialDesignDataGridColumnHeader 	  ColumnHeaderStyle# � 	 6S    	  CanUserReorderColumns .  ��. $
��Auto=�5�   �   
������ 
������� 	  AutoGenerateColumns .   	  SelectionMode$ Single=�5�   n    	  Columns 5�      4
  .System.Windows.Controls.DataGridCheckBoxColumn
  5�   "   ,  &System.Windows.Controls.DataGridColumn   CanUserResize .     Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6O      HeaderTemplate 5�   &   �� 5�   *   .R�5�   .   ��   
 MaterialDesignAccentCheckBox#��� 
 67   6p   5�   +   5�   #   0  *System.Windows.Controls.DataGridTextColumn  5�   "      Header$ Id��65      
IsReadOnly .  .  $ * 6�   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   �� *Id+6�     5�   "   $ 
First Name��65    .  .  $ * 6�    6I   �� *Fname+6�     5�   "   $ 	Last Name��65    .  .  $ * 6�    6H   �� *Lname+6�     5�   "   $ Phone��65    .  .  $ * 6�    6D   �� *Phone+6�    	  RowStyle 5�      �� 5�   "     �� 
TargetType)  #System.Windows.Controls.DataGridRow"   6(     MaterialDesignDataGridRow! �� BasedOn#! [ 6A   " �� Triggers" 5�   &   P� 5�   *   # P� Property# �@J�IsMouseOver$ P� Value$ . . �5�   .   �� % �� Property% � �� , (MaterialDesignDataGridRowHoverBackground& �� Value#& [ 6K   6�   5�   +   5�   #   ' 	  	CellStyle' 5�      �� 5�   "   *  $System.Windows.Controls.DataGridCell"   6(     MaterialDesignDataGridCell#! [ 6B   " 5�   &   P� 5�   *   # �@ 
IsSelected$ . . �5�   .   �� % � ��  MaterialDesignBodyLight#& [ 6L   6   �� 5�   .   % � ��$& 0q�6P   6\   5�   +   5�   #   5�      5�      5�      5�      5�      5�      5�      