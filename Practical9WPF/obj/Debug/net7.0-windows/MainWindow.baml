   M S B A M L   `   `   `  ����H  DPractical9WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Practical9WPFPractical9WPF  5   	       Practical9WPF.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Practical9WPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   ���#696969.��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $	��300��6   $	��500��6!   $��1��6-   $��1��6=   ���#FFF J� Opacity$	 0.5Q�6V   $��Center=�6d   $��Center=�6   �� 5   
   $��1��6   $��1��6%   $��Center=�62   $��Center=�6M   .+�5      �� $��Авторизация��6   $��Center=�6+    �� TextAlignment$ Center=�6H   $��18(�6_   $��10q�6m   �� 5      ���#FFF$��Center=�6$   $��2��6A   $	��400��6L   � 5      $��Center=�6   $��10q�60   .+�5      � .+�5      �� -   5        $��login��5      $	��300��6+   $��16(�67   ��6E   �� *null+�� 5      -   5        $��mailList��5      $	��100��6/   $��16(�6;   $��Center=�6I   .@�5      �� $
��Mail��6'   
 � Tag$ imap.mail.ru��66   �� 5      $��Yandex��6'   $ imap.yandex.ru��68   �� 5      $��Rambler��6'   $ imap.rambler.ru��69   5      5       5!      G� 5"      -   5        $��password��5"      $	��400��6*   $��16(�66   $��10q�6`   ��6D   �� *null+6`   �� 5#      -   5        $��loginBtn��5#      $��
Войти��6%   $��25��65   $��0q�6A   ���#808080$��10q�6j   6v   5$      5%      5&      