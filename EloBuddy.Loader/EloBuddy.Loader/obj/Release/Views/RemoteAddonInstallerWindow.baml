   M S B A M L   `   `   `  ���� J  FEloBuddy.Loader, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:EloBuddy.Loader.ControlsEloBuddy.Loader.Controls  6    0EloBuddy.Loader.Views.RemoteAddonInstallerWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     ;Controls&clr-namespace:EloBuddy.Loader.Controls     -     � Title$  RemoteAddonInstaller��$	��380��$	��720��$��1q�
���   � � WindowStartupLocation$ CenterOwner=� � 
ResizeMode$ NoResize=� � ShowInTaskbar .  ���	#FFFAFAFA.���  � RowDefinitions �� $��40 ��� .+�� $	��Top=����	#FF40A6D1$��40�� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   ShadowDepth$ 3Q�   	Direction$	 270Q�	   Opacity$		 0.2Q�.+��� $��Center=�
 �� Orientation$
 
Horizontal=�$��0,0,1,0q�$��Right=� J� RenderTransformOrigin$ -0.275,0.575&�.+��� -    ��Name$ CloseButton��$��40��$��40��$	����   CloseMinMaxButtonStyle#���   
������ ���	#FF40A6D1
�������$.��(pack://application:,,,/font/#FontAwesome)�$
��20px(�$��Bottom=�/   )EloBuddy.Loader.Controls.HeaderDecoration  $��0,0,1,0q�$��40���� $��Remote Addon Installer��$��20(�$��SemiBold"�
�������$��11,0,0,0q�� $��1�� � ColumnDefinitions �� $��* ��� $
��Auto �$	��250���� $��* � �� $��* ��� $
��Auto ��� $
��Auto ��� $��* ��� $
��Auto �.+��� -    ��Name$ ProjectLabel��$��1��$��1��$	��0 5q�$��Select addon:�����	#FF7E7E7E$��16(�$��1q�$��2���� -    ��Name$ ProjectsComboBox��$��1��$��2��$��Stretch=�$��Center=�  ComboBoxStyle#���  ���	#FFF2F2F2���	#FFD6D6D6 �� 
IsEditable .  $��14(����	#FF929292$��0,0,0,10q��� -   $ NoProjectsLabel��$��1��$��1��$��  No valid addons found��$��20(�$��1q����	#FF1C91D4$
��Bold"�$��1,22,228,10q�$��2��$��2����Z� �� $
 
Horizontal=�$��0��$��3��$��4��$��0 0 0 10q�$��Center=�.+��� -   $ CancelButton��  RoundedSettingsButtonStyle#���  $��Cancel��$
��Bold"����	#FF40A6D1$
��25 8q����	#FFF7F7F7���	#FF40A6D1$��2q��� -   $ InstallButton��$��5 0 0 0q�#���  $��Install��$
��Bold"�
�������$
��25 8q����	#FF40A6D1���	#FF40A6D1$��2q�