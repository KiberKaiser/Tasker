   M S B A M L   `   `   `  ����A  =Tasker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:TaskerTasker  5   	       Tasker.CreateTaskWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Tasker     5   	   -   5          � Title$  Tasker��5   	   $	��326��6    � 
ResizeMode$ NoResize=�6%    � WindowStyle$
 None=�6;   $	��535��6O    � 	Resources 5	         CombinedButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� CornerRadius	 �� Triggers
 P� Property P� Value N� EnterActions �� TargetProperty	 �� To g� Duration N� ExitActions��%  &	        �� 5
   
   " ��6,   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� #��z��6!   #��z��5      #��z��5      $ 3��5      ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver$
 True��6=    5   "   �� 5   &   .��5   *   �� .��5   .   �� $1 +(Border.Background).(SolidColorBrush.Color)�6=    #EAEAEA6�   $ 0:0:0.2D�6�   �� 5   .   $1 +(Button.Foreground).(SolidColorBrush.Color)�6=   	 Black6�   $ 0:0:0.2D�6�   5   +   5   '    5   "   �� 5   &   .��5    *   �� .��5!   .   �� $1 +(Border.Background).(SolidColorBrush.Color)�6=    	#FF0C0C0C6�   $ 0:0:0.2D�6�   �� 5"   .   $1 +(Button.Foreground).(SolidColorBrush.Color)�6=   	 White6�   $ 0:0:0.2D�6�   5#   +   5$   '   5&      5(      5*      �� 5+       � �� �	#FF0C0C0C6+   �� 5,       � ��
 �����6+   �� 5-       � ��$ 0q�60   �� 5.       � ��$ 10,50q�6(   5/      50      .��51      � .+�52   
   �� -   5         ��Name$ CreateTaskLabel��52      $��Create a new task��6)   $
��Left=�6E   $��	10,-6,0,0q�6`   $	��Top=�6s   $��Bahnschrift Condensed)�6�   $��48(�6�   �� 53   
   -   5        $ TitleTaskLabel��53      $��
Title task��6(   $
��Left=�6=   $��	12,45,0,0q�6X   $	��Top=�6k   $��Bahnschrift Condensed)�6�   $��28(�6�   �� 54   
   -   5         ��Name$ TitleTaskTextBox��54      $
��Left=�6,   $��	16,82,0,0q�6G    �� TextWrapping$
 Wrap=�6Z   $	��Top=�6n   $	��512��6�   ���	#FFF7F7F7 �� SelectionBrush �	#FF3A3A3A���	#FFC3C3C3
���   � �� SelectionTextBrush 6�   Z� 6�   �� 55   
   -   5        $ DescriptionTask��55      $��Description��6)   $
��Left=�6?   $��	12,94,0,0q�6Z   $	��Top=�6m   $��Bahnschrift Condensed)�6�   $��28(�6�   �� 56   
   -   5        $ DescriptionTextBox��56      $
��Left=�6.   $��
16,130,0,0q�6I   $
 Wrap=�6]   $	��Top=�6q   $	��512��6�   ���	#FFF7F7F7���	#FFC3C3C3
���   �$	��124��6   6�   Z�  6�   Z� 6  �� 57   
   -   5         ��Name$ CancelButton��57      #��[  6'   $��Cancel��6T   $
��Left=�6e   $��315,269,0,0q�6�   $	��Top=�6�   $��40��6�   $	��101��6�   $��0,0,0,0q�6�   $��22(�6�   $��Bahnschrift SemiBold)�6  ���	#FF131313
���������6�   Z� 6P  �� 58   
   -   5        $ СreateButton��58      #��[  6'   $��Create��6T   $
��Left=�6e   $��424,269,0,0q�6�   $	��Top=�6�   $��40��6�   $	��101��6�   $��0,0,0,0q�6�   $��22(�6�   $��Bahnschrift SemiBold)�6  ���	#FF131313
���������6�   Z� 6P  (  "System.Windows.Controls.DatePicker  59   
   -	   5          Name$ DatePickerTask��59      $
��Left=�6-   $��
71,265,0,0q�6H   $	��Top=�6\   $	��122��6t   
����������	#FFA4A5AB$��24��6�   
���   �6�   �� 5:   
   -
   5        $ TimeTaskTextBox��5:      $
��Left=�6o   $��
71,296,0,0q�6�   $
 Wrap=�6�   $��00:00��6�   $	��Top=�6�   $	��122��6�   $��20��6�   ���	#FFF7F7F76�   �� 5;   
   -   5        $ 	DateLabel��5;      $��Date:��6#   $
��Left=�63   $��
12,252,0,0q�6N   $	��Top=�6b   $��Bahnschrift Condensed)�6z   $��30(�6�   �� 5<   
   -   5        $ 	TimeLabel��5<      $��Time:��6#   $
��Left=�63   $��
12,281,0,0q�6N   $	��Top=�6b   $��Bahnschrift Condensed)�6z   $��30(�6�   5>      5?      