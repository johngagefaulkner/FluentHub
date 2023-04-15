# Updating the Digital Signature
#### Overview

We're temporarily suspending the Digital Signature (Code Signing Certificate) for the `.MSIX` file. If needed, you're able to install it using either of the two following methods:

1. Installation via PowerShell as outlined in the README.
2. Manual installation using the steps below.

### Manual Installation of Code Signing Certificate

1. Right-click on the `.MSIX` file and select <kbd>Properties</kbd>.
2. Select the <kbd>Digital Signatures</kbd> tab.
3. In the "Signature List", only 1 signature should be listed and the <kbd>Name of Signer</kbd> should be "FluentHub". Click on it to select it, then click the <kbd>Details</kbd> button.
4. Click the <kbd>View Certificate</kbd> button.
5. Click the <kbd>Install Certificate</kbd> button. ([**Screenshot**](https://user-images.githubusercontent.com/62196528/197341954-8a967f7b-1711-45e4-aaf7-634b347e1e03.png))
7. Select <kbd>Local Machine</kbd> and hit next. ([**Screenshot**](https://user-images.githubusercontent.com/62196528/197342189-f63b452f-20c5-41b0-a51e-f645ef926761.png))
8. Select <kbd>Place all certificates in the following store:</kbd> and hit <kbd>Browse...</kbd> ([**Screenshot**](https://user-images.githubusercontent.com/62196528/197342238-07a19447-8486-455b-9ad5-075042a2ac44.png))
9. Select <kbd>Trusted People</kbd> and hit <kbd>OK</kbd>. ([**Screenshot**](https://user-images.githubusercontent.com/62196528/197342294-7a2e9547-fe3c-4155-913a-f046b031e03d.png))
