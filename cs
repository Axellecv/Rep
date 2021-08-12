@import url("https://fonts.googleapis.com/css2?family=Fredoka+One&display=swap");
@import url("https://discordstyles.github.io/RadialStatus/base.css");
@import url("https://nyri4.github.io/Discolored/main.css");

:root {
    /* ----------- Dark Base ----------- */
    /* ----- Default Theme --- */
    --dark-primary: #050506;
    --dark-primary-alt: #050505;
    --dark-secondary: #030304;
    --dark-secondary-alt: #010101;
    --dark-tertiary: #000000;
    --dark-modifiers: 168, 113, 182;
    --dark-accent: #050506;
    --dark-accent-dark: #030304;
    --dark-green: #010101;
    --dark-pill-buttons: rgba(132, 101, 138, 0.522);

    /* ----- Status Colors --- */
    --status-online: #00ED8E;
    --status-idle: #ffd37a;
    --status-dnd: #F87E7C;
    --status-offline-invisible: #ADADB8;
    --status-streaming: #7e58be;

    /* ----- Modals & Popouts ---  */
    --dark-layer-primary: var(--dark-primary);
    --dark-layer-secondary: var(--dark-secondary);
    --dark-layer-secondary-alt: var(--dark-secondary-alt);
    --dark-layer-outline: rgb(26, 20, 31, 0.5);

    /* ----- Separation --- */
    --border-radius: 5px;
    --separation-padding: 7px;

    /* ---------- MidnightMars Addons ---------- */
    /* ----- Chat Indicator --- */
    --border-thickness: 3px;
    --border-color: var(--dark-accent);
    --border-hover-color: #64416b;
    --border-roundness: 3px;
    --transition-time: 500ms;
    
    /* ----- Channel Indicators --- */
    --indicator-hovered: rgba(152, 100, 163, 0.09);
    --indicator-rounding: 0;
    --indicator-border-info: 4px solid;
    --indicator-selected: 152, 100, 163;
    --indicator-selected-border: rgba(var(--indicator-selected));
    --indicator-selected-background: rgba(var(--indicator-selected), 0.1);
    --indicator-selected-hover: rgba(var(--indicator-selected), 0.18);
    --indicator-unread: 168, 113, 182;
    --indicator-unread-border: rgba(var(--indicator-unread), 0.55);
    --indicator-unread-background: rgba(var(--indicator-unread), 0.045);
    --indicator-connected: 112, 173, 133;
    --indicator-connected-border: rgba(var(--indicator-connected), 0.55);
    --indicator-connected-background: rgba(var(--indicator-connected), 0.1);
    --indicator-connected-hover: rgba(var(--indicator-connected), 0.18);

    /* ---------- Base Discord Colors ---------- */
    /* ----- Default Theme --- */
    --background-primary: var(--dark-primary);
    --background-secondary: var(--dark-secondary);
    --background-secondary-alt: var(--dark-secondary-alt);
    --background-tertiary: var(--dark-tertiary);
    --background-accent: var(--dark-accent);
    --background-floating: #19131f;
    --channeltextarea-background: var(--dark-secondary-alt);
    --elevation-low: 0 1px 0 rgba(4, 4, 5, 0.2), 0 1.5px 0 rgba(6, 6, 7, 0.05), 0 2px 0 rgba(4, 4, 5, 0.05);
    --elevation-high: 0 8px 16px rgba(0, 0, 0, 0.24);

    /* ----- Text --- */
    --text-normal: #fbfbfb;
    --text-muted: #b2a6b6;
    --text-link: #b6ecc8;
    --channels-default: #b2a6b6;
    --interactive-normal: #c8c8c8;
    --interactive-hover: #dcddde;
    --interactive-active: var(--text-normal);
    --interactive-muted: #6f5e72;
    --header-primary: var(--text-normal);
    --header-secondary: #c9c9c9;

    /* ----- Modifiers --- */
    --background-modifier-selected: rgb(var(--dark-modifiers), 0.09);
    --background-modifier-hover: rgb(var(--midnightmars-modifiers), 0.12);
    --background-modifier-active: rgb(var(--midnightmars-modifiers), 0.18);
    --background-modifier-accent: rgba(170, 150, 176, 0.149);

    /* ----- Toasts --- */
    --toast-background: var(--darkprimary);
    --toast-header: var(--dark-tertiary);
    --toast-contents: var(--dark-secondary);
    --toast-box-shadow: rgba(0, 0, 0, .2);
    --toast-border: var(--dark-tertiary);

    /* ----- Mentions --- */
    --background-mentioned: rgba(68, 109, 83, 0.15);
    --background-mentioned-hover: rgba(68, 109, 83, 0.25);
    --background-mentioned-border: var(--dark-green);

    /* ----- Deprecated --- */
    --deprecated-card-bg: var(--dark-secondary);
    --deprecated-card-editable-bg: var(--dark-secondary);
    --deprecated-text-input-border-disabled: var(--dark-tertiary);
    --deprecated-quickswitcher-input-background: var(--dark-primary);
    --deprecated-quickswitcher-input-placeholder: var(--text-muted);
}

#app-mount .lookFilled-1Gx00P.colorBrand-3pXr91 {
    background-color: var(--dark-accent);
}
#app-mount .lookFilled-1Gx00P.colorBrand-3pXr91:not([disabled]):hover {
    background-color: var(--dark-accent-dark);
}
#app-mount .lookFilled-1Gx00P.colorGrey-2DXtkV,
#app-mount .lookFilled-1Gx00P.colorPrimary-3b3xI6 {
    background-color: rgba(255, 255, 255, 0.1);
}
#app-mount .lookFilled-1Gx00P.colorGrey-2DXtkV:not([disabled]):hover,
#app-mount .lookFilled-1Gx00P.colorPrimary-3b3xI6:not([disabled]):hover {
    background-color: rgba(255, 255, 255, 0.2);
}
#app-mount .container-3auIfb {
    -webkit-transition: 250ms;
    transition: 250ms;
}
#app-mount .container-3auIfb[style="opacity: 1; background-color: rgb(114, 118, 125);"] {
    background-color: var(--dark-pill-buttons) !important;
}
#app-mount .container-3auIfb:not([style="opacity: 1; background-color: rgb(114, 118, 125);"]) {
    background-color: var(--dark-green) !important;
}
#app-mount .container-3auIfb[style="opacity: 1; background-color: rgb(81, 162, 128);"] {
    background-color: #649775 !important;
}
#app-mount .colorable-1bkp8v.primaryDark-3mSFDl {
    --background-secondary: var(--dark-secondary);
    background-color: var(--background-secondary);
}

#app-mount .invite-18yqGF {
    background-color: var(--background-secondary);
    border-color: var(--background-secondary-alt);
}
#app-mount .tile-2OwFgW {
    background-color: var(--background-secondary);
}
#app-mount .tile-2OwFgW:hover {
    background-color: var(--background-secondary-alt);
}
#app-mount .spoilerText-3p6IlD.hidden-HHr2R {
    background-color: var(--background-secondary);
}
#app-mount .spoilerText-3p6IlD.hidden-HHr2R:hover {
    background-color: var(--background-secondary);
}
#app-mount .mentioned-xhSam7:hover {
    background-color: var(--background-mentioned-hover);
}
#app-mount .mentioned-xhSam7::before {
    background-color: var(--background-mentioned-border);
}
#app-mount .mention {
    background-color: var(--background-mentioned);
    color: var(--dark-green);
}
#app-mount .mention:hover {
    background-color: var(--dark-green);
    color: var(--text-normal);
}
#app-mount .replying-1x3H0T,
#app-mount .ephemeral-1PsL1r {
    background-color: rgba(152, 100, 163, 0.15);
}
#app-mount .replying-1x3H0T::before,
#app-mount .ephemeral-1PsL1r::before {
    background-color: var(--dark-accent);
}
#app-mount .ephemeral-1PsL1r .anchorUnderlineOnHover-2ESHQB {
    color: var(--dark-green);
}
#app-mount .reaction-1hd86g {
    border-radius: var(--border-radius);
}
#app-mount .reaction-1hd86g.reactionMe-wv5HKu {
    background-color: rgba(116, 150, 128, 0.15);
    border-color: var(--dark-green);
}
#app-mount .reaction-1hd86g.reactionMe-wv5HKu .reactionCount-2mvXRV {
    color: var(--text-normal);
}

#app-mount .guilds-1SWlCJ {
    border-radius: var(--border-radius);
    margin-top: var(--separation-padding);
    margin-bottom: var(--separation-padding);
    margin-left: var(--separation-padding);
    margin-right: -7px;
}
#app-mount .guilds-1SWlCJ .homeIcon-FuNwkv {
    --scaling: 45px;
    position: absolute;
    margin-left: 6px;
    width: var(--scaling);
    height: var(--scaling);
}
#app-mount .guilds-1SWlCJ .homeIcon-FuNwkv path {
    d: path("M5.2076 2.5672C6.32883 2.9392 7.44289 3.33418 8.57281 3.67624C9.70229 4.01762 10.832 4.45898 11.9898 4.579C13.432 4.72875 14.7947 3.66791 15.253 2.26815C15.4902 1.5426 15.8551 1.76598 16.2647 2.02855C17.9041 3.07993 18.9371 4.63215 19.487 6.44558C19.8361 7.59784 19.885 8.85078 19.9945 10.0654C20.055 10.7352 19.6125 11.1562 19.039 11.4571C15.7807 13.1669 12.7986 12.5231 9.86645 10.5453C8.26883 9.4678 6.56378 8.50355 4.79731 7.74895C3.89698 7.36433 2.75478 7.50733 1.72156 7.5008C0.576228 7.49404 0.174424 7.0734 0.625366 6.04542C1.55271 3.93024 2.54729 2.76446 5.2076 2.5672Z M0.00127989 10.8501C-0.0113201 9.08818 0.0452709 9.14162 1.28804 8.84716C3.83927 8.2424 5.91122 9.23853 7.91003 10.6289C9.39045 11.6582 10.8204 12.7635 12.6092 13.2616C14.5881 13.8131 16.5118 13.7634 18.4321 13.033C18.7038 12.9299 19.0316 12.9767 19.3333 12.9542C19.2876 13.2578 19.2958 13.5832 19.1875 13.8619C18.0008 16.9159 14.4909 17.5207 11.5829 16.2361C10.7216 15.8557 9.85443 15.4592 8.95209 15.2079C7.17014 14.7116 5.43309 15.5173 4.69629 17.2028C4.36694 17.9557 4.07205 17.8815 3.53222 17.4804C1.15609 15.7131 0.269864 13.205 0.00127989 10.8501Z M15.1111 18.7597C13.8718 19.1513 12.8584 19.5393 11.8124 19.7863C10.04 20.2047 8.29907 20.0046 6.64536 19.2218C5.60727 18.7301 5.4894 17.6205 6.35311 16.8698C7.20002 16.1334 8.19823 16.0786 9.14643 16.4377C10.9023 17.1031 12.5468 18.0888 14.4796 18.2191C14.6111 18.2277 14.7308 18.426 15.1111 18.7597Z M5.33334 1.04188C6.25778 0.747008 7.16327 0.346311 8.11087 0.180513C9.68754 -0.0954561 11.2763 -0.102627 12.8166 0.498202C13.5141 0.770042 14.0356 1.19182 13.9981 1.94822C13.96 2.70856 13.3598 3.18791 12.672 3.27571C11.9074 3.37327 11.0689 3.3574 10.3351 3.14684C8.78954 2.70313 7.29134 2.10056 5.77462 1.56058C5.64545 1.51429 5.52334 1.44822 5.39769 1.39151C5.37654 1.27482 5.35471 1.15835 5.33334 1.04188Z") !important;
}
#app-mount .guilds-1SWlCJ .scroller-1Bvpku {
    background-color: var(--dark-secondary);
    padding-top: calc(var(--separation-padding) + 2px);
}
#app-mount .guilds-1SWlCJ .scroller-1Bvpku .expandedFolderBackground-1cujaW,
#app-mount .guilds-1SWlCJ .scroller-1Bvpku .folder-1hbNCn[aria-expanded=true] {
    background-color: var(--dark-primary);
}
#app-mount .guilds-1SWlCJ .scroller-1Bvpku .circleIconButton-1QV--U {
    background-color: var(--dark-primary-alt);
}
#app-mount .guilds-1SWlCJ .scroller-1Bvpku .circleIconButton-1QV--U svg path {
    color: var(--dark-green);
}
#app-mount .guilds-1SWlCJ .scroller-1Bvpku .circleIconButton-1QV--U:hover {
    background-color: var(--dark-green);
}
#app-mount .guilds-1SWlCJ .scroller-1Bvpku .circleIconButton-1QV--U:hover svg path {
    color: #fff;
}
#app-mount .guilds-1SWlCJ .childWrapper-anI2G9 {
    background-color: var(--dark-primary-alt);
}
#app-mount .guilds-1SWlCJ .childWrapper-anI2G9:hover {
    background-color: var(--dark-accent);
}
#app-mount .guilds-1SWlCJ .selected-bZ3Lue .childWrapper-anI2G9 {
    background-color: var(--background-accent);
}

#app-mount .menu-3sdvDG .item-1tOPte:not(.colorDanger-2qLCe1).focused-3afm-j,
#app-mount .menu-3sdvDG .item-1tOPte:not(.colorDanger-2qLCe1):active {
    background-color: var(--dark-accent);
}

.platform-osx .guilds-1SWlCJ .scroller-1Bvpku {
    margin-top: 26px;
}
.platform-osx .guilds-1SWlCJ .unreadMentionsIndicatorTop-2-tcdU {
    margin-top: 26px;
}

#app-mount .scrollerBase-289Jih.disableScrollAnchor-3V9UtP::-webkit-scrollbar-thumb,
#app-mount .scrollerBase-289Jih.auto-Ge5KZx::-webkit-scrollbar-thumb {
    background-color: var(--background-secondary-alt);
    border-radius: var(--border-radius);
}
#app-mount .scrollerBase-289Jih.disableScrollAnchor-3V9UtP::-webkit-scrollbar-track,
#app-mount .scrollerBase-289Jih.auto-Ge5KZx::-webkit-scrollbar-track {
    background-color: var(--background-secondary);
    border-radius: var(--border-radius);
}
#app-mount .scrollerBase-289Jih.thin-1ybCId::-webkit-scrollbar-thumb {
    background-color: var(--background-secondary-alt);
}

#app-mount .titleBar-AC4pGV {
    z-index: 5;
    background-color: var(--background-secondary);
    border-radius: var(--border-radius);
    margin-top: var(--separation-padding);
    margin-right: var(--separation-padding);
    margin-left: var(--separation-padding);
    padding-top: 2px;
}
#app-mount .titleBar-AC4pGV.typeWindows-1za-n7::after {
    content: "";
    position: absolute;
    pointer-events: none;
    background: url("https://raw.githubusercontent.com/LuckFire/midnight-mars/2785c361e2a24e8b62d02f4ba424fa3e2c96c419/src/main/_assets/watermark-icon.svg") 5px 0/15px 17px no-repeat;
    height: 20px;
    width: 20px;
    left: 5px;
    top: 9px;
}
#app-mount .titleBar-AC4pGV .wordmark-2iDDfm svg {
    width: 0;
}
#app-mount .titleBar-AC4pGV .wordmark-2iDDfm::after {
    content: "MIDNIGHT MARS";
    position: absolute;
    font-family: "Fredoka One";
    background: -webkit-gradient(linear, right top, left top, color-stop(60%,
#C779D0), to(#FEAC5E));
    background: linear-gradient(270deg,
#C779D0 60%,
#FEAC5E);
    -webkit-background-clip: text;
    -webkit-text-fill-color: transparent;
    background-clip: text;
    background-size: 200% 200%;
    font-size: 13px;
    font-weight: 600;
    top: 11px;
    left: 29px;
    width: 135px;
}
#app-mount .titleBar-AC4pGV .winButton-iRh8-Z {
    background: var(--icon) 8px 0/13px 15px no-repeat;
    opacity: 0.75;
    margin-top: 4px;
    -webkit-transition: all 0.2s ease;
    transition: all 0.2s ease;
}
#app-mount .titleBar-AC4pGV .winButton-iRh8-Z.winButtonMinMax-PBQ2gm[aria-label=Minimize] {
    --icon: url("https://raw.githubusercontent.com/LuckFire/midnight-mars/main/src/main/_assets/win-buttons/windows-min.svg");
}
#app-mount .titleBar-AC4pGV .winButton-iRh8-Z.winButtonMinMax-PBQ2gm[aria-label=Minimize]:hover {
    --icon: url("https://raw.githubusercontent.com/LuckFire/midnight-mars/main/src/main/_assets/win-buttons/windows-min-active.svg");
}
#app-mount .titleBar-AC4pGV .winButton-iRh8-Z.winButtonMinMax-PBQ2gm[aria-label=Maximize] {
    --icon: url("https://raw.githubusercontent.com/LuckFire/midnight-mars/main/src/main/_assets/win-buttons/windows-max.svg");
}
#app-mount .titleBar-AC4pGV .winButton-iRh8-Z.winButtonMinMax-PBQ2gm[aria-label=Maximize]:hover {
    --icon: url("https://raw.githubusercontent.com/LuckFire/midnight-mars/main/src/main/_assets/win-buttons/windows-max-active.svg");
}
#app-mount .titleBar-AC4pGV .winButton-iRh8-Z.winButtonClose-1HsbF- {
    --icon: url("https://raw.githubusercontent.com/LuckFire/midnight-mars/main/src/main/_assets/win-buttons/windows-close.svg");
}
#app-mount .titleBar-AC4pGV .winButton-iRh8-Z.winButtonClose-1HsbF-:hover {
    --icon: url("https://raw.githubusercontent.com/LuckFire/midnight-mars/main/src/main/_assets/win-buttons/windows-close-active.svg");
}
#app-mount .titleBar-AC4pGV .winButton-iRh8-Z svg {
    color: transparent;
}

#app-mount .container-1r6BKw.themed-ANHk51 {
    --background-secondary: var(--dark-secondary);
    --background-secondary-alt: var(--dark-secondary-alt);
    --background-tertiary: var(--dark-tertiary);
    background-color: var(--background-secondary);
    border-bottom-right-radius: var(--border-radius);
}
#app-mount .container-1r6BKw.themed-ANHk51 .children-19S4PO::after {
    display: none;
}
#app-mount .container-1r6BKw.themed-ANHk51 .toolbar-1t6TWx {
    background-color: var(--background-secondary-alt);
    border-radius: var(--border-radius);
    padding: 5px;
}
#app-mount .container-1r6BKw.themed-ANHk51 .public-DraftStyleDefault-block span[class] {
    background-color: var(--background-primary);
}
#app-mount .container-1r6BKw.themed-ANHk51 .updateIconForeground-3tnNZn {
    fill: var(--dark-green);
}

#app-mount .sidebar-2K8pFh {
    background-color: var(--background-tertiary);
    border-radius: var(--border-radius);
    margin-left: calc(var(--separation-padding) * 2);
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: reverse;
        -ms-flex-direction: column-reverse;
            flex-direction: column-reverse;
}
#app-mount .sidebar-2K8pFh nav {
    border-radius: var(--border-radius);
    margin-bottom: var(--separation-padding);
}
#app-mount .sidebar-2K8pFh > .thin-1ybCId {
    background-color: var(--background-secondary);
    border-radius: var(--border-radius);
    margin-bottom: var(--separation-padding);
}
#app-mount .sidebar-2K8pFh .selectedCategoryItem-FHKU_o .itemInner-gPkiWb {
    background-color: var(--dark-accent);
}

#app-mount .panels-j1Uci_ {
    background-color: var(--background-secondary);
    margin-top: var(--separation-padding);
    margin-bottom: var(--separation-padding);
    border-radius: var(--border-radius);
    display: -webkit-box;
    display: -ms-flexbox;
    display: flex;
    -webkit-box-orient: vertical;
    -webkit-box-direction: reverse;
        -ms-flex-direction: column-reverse;
            flex-direction: column-reverse;
}
#app-mount .panels-j1Uci_ .alignStretch-DpGPf3 {
    background-color: var(--background-secondary-alt);
    border-radius: var(--border-radius);
}
#app-mount .panels-j1Uci_ .activityPanel-28dQGo,
#app-mount .panels-j1Uci_ .container-1giJp5 {
    border-top: 2px dotted var(--background-modifier-accent);
    border-bottom: none;
}

#app-mount .form-2fGMdU .scrollableContainer-2NUZem {
    border-radius: var(--border-radius);
    border-bottom-right-radius: var(--border-roundness);
    border-bottom-left-radius: var(--border-roundness);
    border-bottom: solid var(--border-thickness) var(--background-tertiary);
    -webkit-transition: all var(--transition-time);
    transition: all var(--transition-time);
}
#app-mount .form-2fGMdU:focus-within .scrollableContainer-2NUZem {
    border-color: var(--border-color);
}
#app-mount .form-2fGMdU:hover .scrollableContainer-2NUZem:not(:focus-within) {
    border-color: var(--border-hover-color);
}
#app-mount .contents-2mQqc9 .scrollableContainer-2NUZem {
    border-radius: var(--border-radius);
    border-bottom-right-radius: var(--border-roundness);
    border-bottom-left-radius: var(--border-roundness);
    border-bottom: solid var(--border-thickness) var(--background-tertiary);
    -webkit-transition: all var(--transition-time);
    transition: all var(--transition-time);
}
#app-mount .contents-2mQqc9:focus-within .scrollableContainer-2NUZem {
    border-color: var(--border-color);
}
#app-mount .contents-2mQqc9:hover .scrollableContainer-2NUZem:not(:focus-within) {
    border-color: var(--border-hover-color);
}

#app-mount .chat-3bRxxu {
    background-color: var(--background-tertiary);
    border-radius: var(--border-radius);
    margin: var(--separation-padding) calc(var(--separation-padding) * 2) var(--separation-padding) 0;
    left: var(--separation-padding);
}
#app-mount .chat-3bRxxu .chatContent-a9vAAp {
    background-color: var(--background-primary);
    border-bottom-right-radius: var(--border-radius);
}
#app-mount .newMessagesBar-265mhP {
    background-color: var(--background-accent);
    border-bottom-right-radius: var(--border-radius);
    border-bottom-left-radius: var(--border-radius);
}
#app-mount .isUnread-3Ef-o9 {
    background-color: var(--background-accent);
    border-color: var(--background-accent);
}
#app-mount .isUnread-3Ef-o9 .content-1o0f9g {
    color: var(--text-normal);
}
#app-mount .isUnread-3Ef-o9 .unreadPill-2HyYtt {
    background-color: var(--background-accent);
}
#app-mount .isUnread-3Ef-o9 .unreadPill-2HyYtt .unreadPillCapStroke-7rkHbg {
    fill: var(--background-accent);
    color: var(--background-accent);
}
#app-mount .message-2qnXI6 .wrapper-2aW0bm {
    background-color: var(--background-secondary-alt);
    -webkit-filter: drop-shadow(0 0 8px var(--background-tertiary));
            filter: drop-shadow(0 0 8px var(--background-tertiary));
}
#app-mount .message-2qnXI6.groupStart-23k01U::after {
    content: "";
    position: absolute;
    background-color: var(--background-modifier-accent);
    width: 97.8%;
    height: 1px;
    top: 0;
    left: 16px;
}
#app-mount .message-2qnXI6.groupStart-23k01U:not(.compact-T3H92H):after {
    top: -9px;
}
#app-mount .divider-3_HH5L + .message-2qnXI6.groupStart-23k01U::after {
    content: none;
}
#app-mount .container-3RCQyg {
    border: none;
}

#app-mount .chatContent-a9vAAp::before {
    content: "";
    position: absolute;
    border-top-left-radius: var(--border-radius);
    -webkit-box-shadow: 0 -25px 0 0 var(--background-primary);
            box-shadow: 0 -25px 0 0 var(--background-primary);
    top: 0;
    right: -30px;
    height: 50px;
    width: 30px;
}
#app-mount .members-1998pB {
    margin-top: calc(var(--separation-padding) - 2px);
    margin-left: calc(var(--separation-padding) - 2px);
    border-radius: var(--border-radius);
}
#app-mount .botTag-2WPJ74 {
    background-color: var(--dark-green);
    color: #fff;
}

#app-mount .root-1gCeng:not(.popout-103y-5) {
    background-color: var(--background-primary);
    -webkit-box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
            box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
}
#app-mount .root-1gCeng:not(.popout-103y-5) .header-1TKi98.separator-2-RRj_ {
    -webkit-box-shadow: 0 1px 0 0 var(--background-tertiary), 0 1px 2px 0 rgba(24, 25, 28, 0.3);
            box-shadow: 0 1px 0 0 var(--background-tertiary), 0 1px 2px 0 rgba(24, 25, 28, 0.3);
}
#app-mount .root-1gCeng:not(.popout-103y-5) .footer-2gL1pp {
    background-color: var(--background-secondary);
    -webkit-box-shadow: inset 0 1px 0 var(--dark-layer-outline);
            box-shadow: inset 0 1px 0 var(--dark-layer-outline);
}

:root {
    --jcs-background-primary: var(--dark-primary);
    --jcs-background-secondary: var(--dark-secondary);
    --jcs-background-secondary-alt: var(--dark-secondary-alt);
    --jcs-background-tertiary: var(--dark-tertiary);
    --jcs-text-normal: var(--text-normal);
    --jcs-header-primary: var(--header-primary);
    --jcs-header-secondary: var(--header-secondary);
    --jcs-background-modifier-accent: var(--background-modifier-accent);
    --jcs-background-modifier-hover: var(--background-modifier-hover);
    --jcs-deprecated-text-input-bg: var(--deprecated-text-input-bg);
    --jcs-deprecated-text-input-border: var(--deprecated-text-input-border);
}

#app-mount .theme-light .root-1gCeng {
    background-color: var(--jcs-background-primary);
    -webkit-box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
            box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
}
#app-mount .theme-light .root-1gCeng .colorStandard-2KCXvj {
    color: var(--jcs-text-normal);
}
#app-mount .theme-light .root-1gCeng .colorHeaderPrimary-26Jzh- {
    color: var(--jcs-header-primary);
}
#app-mount .theme-light .root-1gCeng .colorHeaderSecondary-3Sp3Ft {
    color: var(--jcs-header-secondary);
}
#app-mount .theme-light .root-1gCeng .lookBlank-3eh9lL div,
#app-mount .theme-light .root-1gCeng .lookLink-9FtZy- div {
    color: var(--jcs-text-normal);
}
#app-mount .theme-light .root-1gCeng .scrollerBase-289Jih::-webkit-scrollbar-thumb {
    background-color: var(--jcs-background-secondary-alt);
}
#app-mount .theme-light .root-1gCeng .container-UC8Ug1 {
    background-color: var(--jcs-background-primary);
    border: 1px solid var(--jcs-background-modifier-accent);
}
#app-mount .theme-light .root-1gCeng .container-UC8Ug1:hover {
    background-color: var(--jcs-background-modifier-hover);
    border: 1px solid var(--jcs-background-modifier-accent);
}
#app-mount .theme-light .root-1gCeng .inputWrapper-31_8H8.input--jS-j2 {
    background-color: var(--jcs-background-tertiary);
    border-radius: 3px;
}
#app-mount .theme-light .root-1gCeng .sampleLink-2NLvZg {
    color: var(--jcs-header-primary);
}
#app-mount .theme-light .root-1gCeng .input-cIJ7To {
    background-color: var(--jcs-deprecated-text-input-bg);
    color: var(--jcs-text-normal);
    border: 1px solid var(--jcs-deprecated-text-input-border);
}
#app-mount .theme-light .root-1gCeng .footer-2gL1pp {
    background-color: var(--jcs-background-secondary);
    -webkit-box-shadow: inset 0 1px 0 var(--jcs-background-tertiary);
            box-shadow: inset 0 1px 0 var(--jcs-background-tertiary);
}

#app-mount .keyboardShortcutsModal-3piNz7 {
    background-color: var(--background-primary);
    -webkit-box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
            box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
}
#app-mount .keyboardShortcutsModal-3piNz7 .modalTitle-37O4n6 {
    background-color: var(--dark-layer-secondary-alt);
    color: var(--header-primary);
}
#app-mount .keyboardShortcutsModal-3piNz7 .modalSubtitle-1Pj5nv {
    background-color: var(--dark-layer-secondary-alt);
    color: var(--text-normal);
    border-bottom: 1px solid var(--dark-tertiary);
    padding-top: 5px;
    margin-top: -5px;
}
#app-mount .keyboardShortcutsModal-3piNz7 .keybindDescription-2RDbC2 {
    color: var(--header-secondary);
}

#app-mount .message-2qRu38 {
    background-color: var(--background-secondary);
    -webkit-box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
            box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
}

#app-mount .container-1If-HZ.root-1gCeng .scroller-1-nKid {
    background-color: var(--background-secondary);
}
#app-mount .container-1If-HZ.root-1gCeng .reactionSelected-1pqISm {
    background-color: var(--background-modifier-selected);
}
#app-mount .container-1If-HZ.root-1gCeng .reactionDefault-GBA58K:hover {
    background-color: var(--background-modifier-active);
}
#app-mount .container-1If-HZ.root-1gCeng .reactors-Blmlhw {
    background-color: var(--background-primary);
}
#app-mount .container-1If-HZ.root-1gCeng .reactor-3UBcOI {
    -webkit-box-shadow: inset 0 -1px 0 var(--background-modifier-accent);
            box-shadow: inset 0 -1px 0 var(--background-modifier-accent);
}

#app-mount .modalSize-cqUaws .tile-2w4k5N:hover .sourceThumbnail-27dolk {
    -webkit-box-shadow: 0 0 0 2px var(--dark-accent);
            box-shadow: 0 0 0 2px var(--dark-accent);
}
#app-mount .modalSize-cqUaws .sourceThumbnail-27dolk.selected-1nOkyc {
    -webkit-box-shadow: 0 0 0 2px var(--dark-accent);
            box-shadow: 0 0 0 2px var(--dark-accent);
}
#app-mount .modalSize-cqUaws .selectorButton-EEUWed:not(.selectorButtonPremiumRequired-mKMbIu):hover,
#app-mount .modalSize-cqUaws .selectorButtonSelected-t5V9On {
    background-color: var(--dark-accent);
}

#app-mount .uploadModal-2ifh8j {
    background-color: var(--background-primary);
    -webkit-box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
            box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
}
#app-mount .uploadModal-2ifh8j .footer-3mqk7D {
    background-color: var(--background-secondary);
    -webkit-box-shadow: inset 0 1px 0 var(--dark-layer-outline);
            box-shadow: inset 0 1px 0 var(--dark-layer-outline);
}
#app-mount .uploadModal-2ifh8j .comment-4IWttf .scrollableContainer-2NUZem {
    border-radius: var(--border-radius);
    border-bottom-right-radius: var(--border-roundness);
    border-bottom-left-radius: var(--border-roundness);
    border-bottom: solid var(--border-thickness) var(--background-tertiary);
    -webkit-transition: all var(--transition-time);
    transition: all var(--transition-time);
}
#app-mount .uploadModal-2ifh8j .comment-4IWttf:focus-within .scrollableContainer-2NUZem {
    border-color: var(--border-color);
}
#app-mount .uploadModal-2ifh8j .comment-4IWttf:hover .scrollableContainer-2NUZem:not(:focus-within) {
    border-color: var(--border-hover-color);
}

#app-mount .root-SR8cQa .topSectionPlaying-1J5E4n {
    background-color: var(--dark-accent);
}
#app-mount .root-SR8cQa .topSectionSpotify-1lI0-P {
    background-color: var(--dark-green);
}
#app-mount .root-SR8cQa .connectedAccount-36nQx7 {
    background-color: var(--background-secondary-alt);
    border-color: var(--backgrond-secondary-alt);
}
#app-mount .root-SR8cQa .flowerStar-1GeTsn path {
    fill: rgba(255, 255, 255, 0.25);
}
#app-mount .root-SR8cQa .childContainer-1wxZNh {
    margin-top: 2px;
}
#app-mount .root-SR8cQa .actionButton-3W1xZa.lookFilled-1Gx00P.colorGreen-29iAKY {
    background-color: var(--dark-green);
}
#app-mount .root-SR8cQa .actionButton-3W1xZa.lookInverted-2D7oAl.colorBrand-3pXr91 {
    color: var(--dark-accent);
}

#app-mount .container-1D34oG {
    position: relative;
    background-color: var(--background-tertiary);
    border-radius: var(--border-radius);
    margin: var(--separation-padding) calc(var(--separation-padding) * 2) var(--separation-padding) 0;
    left: var(--separation-padding);
}

#app-mount .peopleList-3c4jOR,
#app-mount .friendsEmpty-1K9B4k {
    background-color: var(--background-primary);
}
#app-mount .title-30qZAO {
    margin-left: 13px;
}
#app-mount .peopleListItem-2nzedh {
    background-color: var(--background-secondary);
    border-radius: 5px;
    border: solid 1px var(--background-secondary-alt);
    padding: 10px;
    margin: 8px;
    margin-left: 12px;
}
#app-mount .peopleListItem-2nzedh .actionButton-uPB8Fs {
    background-color: var(--background-modifier-accent);
}
#app-mount .peopleListItem-2nzedh:hover {
    background-color: var(--background-secondary-alt);
}
#app-mount .peopleListItem-2nzedh:hover .actionButton-uPB8Fs {
    background-color: var(--background-tertiary);
}
#app-mount .nowPlayingColumn-2sl4cE {
    background-color: var(--background-tertiary);
}
#app-mount .nowPlayingColumn-2sl4cE::before {
    content: "";
    position: absolute;
    border-top-left-radius: var(--border-radius);
    -webkit-box-shadow: 0 -25px 0 0 var(--background-primary);
            box-shadow: 0 -25px 0 0 var(--background-primary);
    height: 50px;
    width: 30px;
}
#app-mount .nowPlayingColumn-2sl4cE .scroller-2ZPeAD {
    background-color: var(--background-secondary);
    margin-top: calc(var(--separation-padding) - 2px);
    margin-left: calc(var(--separation-padding) - 2px);
    border-radius: var(--border-radius);
}
#app-mount .nowPlayingColumn-2sl4cE .itemCard-v9viV7 {
    background-color: var(--background-secondary-alt);
}
#app-mount .nowPlayingColumn-2sl4cE .itemCard-v9viV7:hover {
    background-color: var(--background-tertiary);
}
#app-mount .nowPlayingColumn-2sl4cE .itemCard-v9viV7 .section-2gLsgF {
    background-color: var(--background-primary);
}

#app-mount .container-3Mxszk {
    position: relative;
    background-color: var(--background-tertiary);
    border-radius: var(--border-radius);
    margin: var(--separation-padding) calc(var(--separation-padding) * 2) var(--separation-padding) 0;
    left: var(--separation-padding);
}
#app-mount .container-3Mxszk .installationPath-3cStrB {
    -webkit-box-shadow: 0 1px 0 0 var(--background-modifier-accent);
            box-shadow: 0 1px 0 0 var(--background-modifier-accent);
}
#app-mount .container-3Mxszk .installationPath-3cStrB circle.background-yZEZik {
    stroke: var(--background-modifier-accent);
}
#app-mount .container-3Mxszk .installationPath-3cStrB .defaultIndicator-3WqGFB {
    background-color: var(--background-modifier-accent);
}
#app-mount .container-3Mxszk .installationPath-3cStrB .rowBody-3dJTTZ {
    color: var(--text-muted);
}
#app-mount .container-3Mxszk .hiddenLibraryApplication-T6N3U1 {
    border-bottom-color: var(--background-modifier-accent);
}
#app-mount .container-3Mxszk .hiddenLibraryApplication-T6N3U1::before {
    background-color: var(--background-secondary);
    border-color: var(--background-tertiary);
}
#app-mount .container-3Mxszk .hiddenLibraryApplication-T6N3U1 .restoreButton-3jU0Z6 {
    background-color: var(--background-primary);
    -webkit-box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 1px 5px 0 rgba(0, 0, 0, 0.3);
            box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 1px 5px 0 rgba(0, 0, 0, 0.3);
}
#app-mount .container-3Mxszk .hiddenLibraryApplication-T6N3U1 .applicationSubText-2V8LSK {
    color: var(--text-muted);
}

#app-mount .applicationStore-1pNvnv {
    position: relative;
    background-color: var(--background-tertiary);
    border-radius: var(--border-radius);
    margin: var(--separation-padding) calc(var(--separation-padding) * 2) var(--separation-padding) 0;
    left: var(--separation-padding);
}
#app-mount .featureChildrenWrapper-smz30S > div {
    background-color: var(--background-secondary);
}

#app-mount .perksModal-fSYqOq {
    background-color: var(--background-primary);
}
#app-mount .perksModal-fSYqOq .barBackground-2EEiLw {
    background-color: var(--background-secondary);
}
#app-mount .perksModal-fSYqOq .tierMarkerBackground-3q29am {
    background-color: var(--background-secondary);
}
#app-mount .perksModal-fSYqOq .tierMarkerInProgress-24LMzJ {
    background-color: var(--background-secondary) !important;
}
#app-mount .perksModal-fSYqOq .tierHeaderLocked-1s2JJz {
    background-color: var(--background-secondary-alt);
}
#app-mount .perksModal-fSYqOq .tierBody-16Chc9 {
    background-color: var(--background-secondary);
}
#app-mount .perksModal-fSYqOq .perk-2WeBWW {
    background-color: var(--background-secondary);
}

#app-mount .pageWrapper-1PgVDX {
    background-color: var(--background-primary);
    border-radius: var(--border-radius);
    margin: var(--separation-padding) calc(var(--separation-padding) * 2) var(--separation-padding) 0;
    left: var(--separation-padding);
}

#app-mount .container-2Bfwy4 {
    margin: var(--separation-padding);
}
#app-mount .container-2Bfwy4 .container-1r6BKw.themed-ANHk51 {
    border-top-left-radius: var(--border-radius);
    border-top-right-radius: var(--border-radius);
}
#app-mount .container-2Bfwy4 .content-MLh4nU {
    border-bottom-left-radius: var(--border-radius);
    border-bottom-right-radius: var(--border-radius);
}

#app-mount .autocomplete-1vrmpx {
    background-color: var(--background-secondary);
}
#app-mount .autocomplete-1vrmpx .selected-1Tbx07 {
    background-color: var(--background-primary);
}
#app-mount .autocomplete-1vrmpx .categoryHeader-O1zU94 {
    background-color: var(--background-secondary);
}

#app-mount .colorPickerCustom-2CWBn2 {
    background-color: var(--background-primary);
    border-color: var(--background-tertiary);
}

#app-mount .calendarPicker-2yf6Ci .react-datepicker {
    background-color: var(--dark-secondary);
}
#app-mount .react-datepicker__navigation {
    border-color: var(--background-floating);
}
#app-mount .react-datepicker__header {
    background-color: var(--dark-secondary);
    border-color: var(--background-modifier-accent);
}
#app-mount .react-datepicker__current-month {
    border-bottom-color: var(--background-modifier-accent);
}
#app-mount .react-datepicker__day--today::after {
    background-color: var(--dark-accent);
}
#app-mount .react-datepicker__day {
    border-top-color: var(--background-tertiary);
    border-left-color: var(--background-tertiary);
}
#app-mount .react-datepicker__day:hover:not(.react-datepicker__day--disabled) {
    background-color: var(--dark-accent);
}
#app-mount .react-datepicker__day--outside-month,
#app-mount .react-datepicker__day--disabled {
    background-color: var(--dark-secondary-alt);
}
#app-mount .datePickerHint-3Q1Udw {
    border-top-color: var(--background-modifier-accent);
}
#app-mount .datePickerHint-3Q1Udw .hintValue-29ny8Z {
    background-color: var(--dark-accent);
}

#app-mount .popout-103y-5 {
    background-color: var(--dark-layer-primary);
    -webkit-box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
            box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
}
#app-mount .popout-103y-5 .friendSelected-1sa4bG {
    background-color: var(--background-modifier-selected);
}

#app-mount .streamPreview-2-WUWT {
    background-color: var(--background-secondary-alt);
}
#app-mount .streamPreview-2-WUWT .previewContainer-12UlHl {
    background-color: var(--background-secondary-alt);
}

#app-mount .searchResultsWrap-3-pOjs {
    margin-top: calc(var(--separation-padding) - 2px);
    margin-left: calc(var(--separation-padding) - 2px);
    border-radius: var(--border-radius);
}
#app-mount .searchResultsWrap-3-pOjs .searchHeader-2XoQg7 {
    background-color: var(--background-secondary-alt);
}

#app-mount .container-3ayLPN#search-results {
    background-color: var(--dark-layer-secondary);
    -webkit-box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
            box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 2px 10px 0 rgba(0, 0, 0, 0.2);
}
#app-mount .container-3ayLPN#search-results .queryContainer-RKFJW- {
    border-bottom-color: var(--dark-layer-secondary-alt);
}
#app-mount .container-3ayLPN#search-results .focused-2bY0OD {
    background-color: var(--dark-layer-secondary-alt);
}
#app-mount .container-3ayLPN#search-results .option-96V44q::after {
    background: transparent;
}
#app-mount .container-3ayLPN#search-results .option-96V44q.selected-rZcOL- {
    background-color: var(--background-tertiary);
}
#app-mount .container-3ayLPN#search-results .option-96V44q.selected-rZcOL-::before {
    background: -webkit-gradient(linear, left top, right top, from(rgba(0, 0, 0, 0)), color-stop(80%, var(--background-tertiary)));
    background: linear-gradient(90deg, rgba(0, 0, 0, 0), var(--background-tertiary) 80%);
    padding-left: 10px;
}
#app-mount .container-3ayLPN#search-results .option-96V44q.selected-rZcOL-::after {
    background: -webkit-gradient(linear, left top, right top, from(rgba(0, 0, 0, 0)), color-stop(50%, var(--background-tertiary)));
    background: linear-gradient(90deg, rgba(0, 0, 0, 0), var(--background-tertiary) 50%);
}
#app-mount .container-3ayLPN#search-results .option-96V44q:not(.searchOption-zQ-1l6) .filter-3Y_im- {
    color: var(--text-muted);
}
#app-mount .container-3ayLPN#search-results .option-96V44q:not(.searchOption-zQ-1l6) .answer-1n6g43 {
    color: var(--text-normal);
}
#app-mount .container-3ayLPN#search-results .searchOption-zQ-1l6 .filter-3Y_im- {
    color: var(--text-normal);
}
#app-mount .container-3ayLPN#search-results .searchOption-zQ-1l6 .answer-1n6g43 {
    color: var(--text-muted);
}

#app-mount #status-picker #status-picker-online.focused-3afm-j {
    background-color: #00ED8E;
}
#app-mount #status-picker #status-picker-online:not(.focused-3afm-j) .status-1AY8sU {
    background-color: #00ED8E !important;
}
#app-mount #status-picker #status-picker-idle.focused-3afm-j {
    background-color: #ffd37a;
}
#app-mount #status-picker #status-picker-idle:not(.focused-3afm-j) .status-1AY8sU {
    background-color: #ffd37a !important;
}
#app-mount #status-picker #status-picker-dnd.focused-3afm-j {
    background-color: #F87E7C;
}
#app-mount #status-picker #status-picker-dnd:not(.focused-3afm-j) .status-1AY8sU {
    background-color: #F87E7C !important;
}
#app-mount #status-picker #status-picker-invisible.focused-3afm-j {
    background-color: #747F8D;
}
#app-mount #status-picker #status-picker-invisible:not(.focused-3afm-j) .status-1AY8sU {
    background-color: #747F8D !important;
}

#app-mount .userPopout-3XzG_A {
    -webkit-box-shadow: 0 2px 10px 0 rgba(0, 0, 0, 0.2), 0 0 0 1px var(--dark-layer-outline);
            box-shadow: 0 2px 10px 0 rgba(0, 0, 0, 0.2), 0 0 0 1px var(--dark-layer-outline);
}
#app-mount .userPopout-3XzG_A .body-3iLsc4,
#app-mount .userPopout-3XzG_A .footer-1fjuF6 {
    background-color: var(--background-secondary);
}
#app-mount .userPopout-3XzG_A .input-cIJ7To:focus {
    border-color: var(--dark-accent);
}
#app-mount .headerNormal-T_seeN {
    background-color: var(--background-tertiary);
}
#app-mount .headerPlaying-j0WQBV {
    background-color: var(--dark-accent);
}
#app-mount .headerSpotify-zpWxgT {
    background-color: var(--dark-green);
}

#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] {
    background-color: transparent;
    margin: var(--separation-padding);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .standardSidebarView-3F1I7i {
    background-color: transparent;
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .contentRegion-3nDuYy {
    border-radius: var(--border-radius);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .contentRegionScroller-26nc1e {
    border-radius: var(--border-radius);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .sidebarRegionScroller-3MXcoP {
    border-radius: var(--border-radius);
    margin-right: var(--separation-padding);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .closeButton-1tv5uR {
    border-color: var(--background-secondary-alt);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .closeButton-1tv5uR:hover {
    background-color: var(--background-secondary-alt);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .keybind-KpFkfr {
    color: var(--text-normal);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .card-FDVird::before {
    background-color: var(--background-secondary);
    border-color: var(--background-tertiary);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .card-FDVird .button-2CgfFz {
    background-color: var(--background-primary);
    -webkit-box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 1px 5px 0 rgba(0, 0, 0, 0.3);
            box-shadow: 0 0 0 1px var(--dark-layer-outline), 0 1px 5px 0 rgba(0, 0, 0, 0.3);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .card-FDVird .hoverRoll-YK53gQ {
    color: var(--text-muted);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .marginTop20-3TxNs6 .bar-2Qqk5Z,
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .flexChild-faoVW3 .bar-2Qqk5Z {
    background-color: #5E5161;
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .marginTop20-3TxNs6 .bar-2Qqk5Z .barFill-23-gu-,
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .flexChild-faoVW3 .bar-2Qqk5Z .barFill-23-gu- {
    background-color: var(--dark-accent);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .markDash-3hAolZ {
    background-color: #5E5161;
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .markValue-2DwdXI {
    color: #89798d;
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .checkbox-1ix_J3 {
    background-color: var(--dark-accent) !important;
    border-color: var(--dark-accent) !important;
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .radioIconForeground-XwlXQN {
    color: var(--dark-accent);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .avatarUploaderInner-3UNxY3 {
    background-color: var(--dark-accent);
}
#app-mount .layer-3QrUeG[aria-label*=_SETTINGS] .noticeRegion-1YviSH > div[style="background-color: rgba(32, 34, 37, 0.9);"] {
    background-color: var(--background-tertiary) !important;
    -webkit-transition: 200ms;
    transition: 200ms;
}

#app-mount [aria-label=CHANNEL_SETTINGS] .allow-1PzSY3.selected-2YhbGh {
    background-color: var(--dark-green);
}
#app-mount [aria-label=CHANNEL_SETTINGS] .allow-1PzSY3.selected-2YhbGh svg path {
    fill: #fff;
}
#app-mount [aria-label=CHANNEL_SETTINGS] .allow-1PzSY3 svg path {
    fill: var(--dark-green);
}

#app-mount .layer-3QrUeG[aria-label*=GUILD_SETTINGS] .inputMini-2xQV9P {
    background-color: var(--background-secondary-alt);
}
#app-mount .layer-3QrUeG[aria-label*=GUILD_SETTINGS] .auditLog-3jNbM6 {
    background-color: var(--background-secondary);
    border-color: var(--background-tertiary);
}
#app-mount .layer-3QrUeG[aria-label*=GUILD_SETTINGS] .auditLog-3jNbM6 .headerExpanded-CUEwZ5 {
    background-color: var(--background-secondary-alt);
}
#app-mount .layer-3QrUeG[aria-label*=GUILD_SETTINGS] .auditLog-3jNbM6 .changeDetails-bk98pu {
    background-color: var(--background-secondary);
}
#app-mount .layer-3QrUeG[aria-label*=GUILD_SETTINGS] .auditLog-3jNbM6 .typeCreate-1kfBMl {
    color: var(--dark-green);
}
#app-mount .layer-3QrUeG[aria-label*=GUILD_SETTINGS] .background-3xPPFc {
    color: var(--background-secondary);
}
#app-mount .layer-3QrUeG[aria-label*=GUILD_SETTINGS] .tierInProgress-3mBoXq {
    background-color: var(--background-secondary);
}
#app-mount .layer-3QrUeG[aria-label*=GUILD_SETTINGS] .tierHeaderLocked-1a2opw {
    background-color: var(--background-secondary-alt);
}
#app-mount .layer-3QrUeG[aria-label*=GUILD_SETTINGS] .tierBody-x9kBBp {
    background-color: var(--background-secondary);
}

#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .background-1QDuV2 {
    --padding: 20px;
    background-color: transparent !important;
    padding: 0;
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .background-1QDuV2 .profile-1eT9hT {
    background-color: var(--background-secondary);
    border: 1px solid var(--background-tertiary);
    border-radius: var(--border-radius);
    padding: var(--padding);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .background-1QDuV2 .fieldList-21DyL8 {
    background-color: var(--background-secondary);
    border: 1px solid var(--background-tertiary);
    border-radius: var(--border-radius);
    margin-top: 5px;
    padding: var(--padding);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .authedApp-mj2Hmd {
    background-color: var(--background-secondary);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .connection-1fbD7X {
    background-color: var(--background-secondary-alt);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .connectionHeader-2MDqhu {
    background-color: var(--background-secondary);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .subscriptionDetails-1dUmjl,
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .sectionAccountCredit-1uNhnJ {
    border-color: var(--background-modifier-accent);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .accountCreditRow-SHgyi0 {
    border-bottom: none;
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .paymentPane-3bwJ6A {
    background-color: var(--background-secondary);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .paymentPane-3bwJ6A .paginator-166-09,
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .paymentPane-3bwJ6A .bottomDivider-1K9Gao {
    background-color: var(--background-secondary);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .paymentPane-3bwJ6A .bottomDivider-1K9Gao {
    border-bottom-color: var(--background-primary);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .codeRedemptionRedirect-1wVR4b {
    background-color: var(--background-secondary);
    border-color: var(--background-tertiary);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .progress-1IcQ3A {
    background-color: rgba(255, 255, 255, 0.3);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .notches-1sAcEM {
    background-image: url("data:image/svg+xml;charset=utf-8,%3Csvg xmlns='http://www.w3.org/2000/svg' width='8' height='20' fill='%2336263A'%3E%3Cpath fill-rule='evenodd' d='M0 0h8v20H0V0zm4 2a2 2 0 00-2 2v12a2 2 0 104 0V4a2 2 0 00-2-2z'/%3E%3C/svg%3E");
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .previewOverlay-2O7_KC {
    background-color: var(--background-secondary);
    border-color: var(--background-tertiary);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .notDetected-33MY4s {
    background-color: rgba(255, 255, 255, 0.15);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .nowPlaying-284llR {
    background-color: var(--midnightmars-green);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .game-1ipmAa {
    -webkit-box-shadow: 0 1px 0 0 var(--background-modifier-accent);
            box-shadow: 0 1px 0 0 var(--background-modifier-accent);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .flowerStar-1GeTsn path {
    fill: var(--dark-accent);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .wrapper-3jrx9n {
    border-color: var(--dark-accent);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .option-n0icdO {
    background-color: rgba(255, 255, 255, 0.2);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .option-n0icdO:hover {
    background-color: var(--dark-accent);
}
#app-mount .layer-3QrUeG[aria-label*=USER_SETTINGS] .option-n0icdO.selected-mKYnfr {
    background-color: var(--dark-accent);
}

:root {
    /* ----- RadialStatus by Gibbu --- */
    --rs-small-spacing: 2px;
    --rs-large-spacing: 2px;
    --rs-width: 2px;
    --rs-avatar-shape: 50%;
    --rs-online-color: var(--status-online);
    --rs-idle-color: var(--status-idle);
    --rs-dnd-color: var(--status-dnd);
    --rs-offline-color: var(--status-offinle-invisible);
    --rs-streaming-color: var(--status-streaming);
    --rs-invisible-color: var(--status-offinle-invisible);
}

#app-mount .containerDefault--pIXnN .wrapper-2jXpOf,
#app-mount .channel-2QD9_O {
    border-radius: var(--indicator-rounding);
}
#app-mount .containerDefault--pIXnN .wrapper-2jXpOf::before,
#app-mount .channel-2QD9_O::before {
    content: "";
    position: absolute;
    border-radius: 25px;
    top: 1px;
    left: 2px;
    bottom: 1px;
}
#app-mount .containerDefault--pIXnN .wrapper-2jXpOf:not(.modeSelected-346R90):not(.modeConnected-3IsKId) .content-1x5b-n:hover,
#app-mount .channel-2QD9_O:not(.selected-aXhQR6) .content-1x5b-n:hover {
    background: var(--indicator-hovered);
}
#app-mount .modeSelected-346R90 .content-1x5b-n,
#app-mount .channel-2QD9_O.selected-aXhQR6 .content-1x5b-n {
    background-color: var(--indicator-selected-background);
}
#app-mount .modeSelected-346R90 .content-1x5b-n:hover,
#app-mount .channel-2QD9_O.selected-aXhQR6 .content-1x5b-n:hover {
    background-color: var(--indicator-selected-hover);
}
#app-mount .modeSelected-346R90::before,
#app-mount .channel-2QD9_O.selected-aXhQR6::before {
    border-left: var(--indicator-border-info) var(--indicator-selected-border);
}
#app-mount .modeUnread-1qO3K1 .content-1x5b-n {
    background-color: var(--indicator-unread-background);
}
#app-mount .modeUnread-1qO3K1 .content-1x5b-n:hover {
    background-color: var(--indicator-unread-hover);
}
#app-mount .modeUnread-1qO3K1::before {
    border-left: var(--indicator-border-info) var(--indicator-unread-border);
}
#app-mount .modeUnread-1qO3K1 .unread-2lAfLh {
    display: none;
}
#app-mount .modeConnected-3IsKId .content-1x5b-n {
    background-color: var(--indicator-connected-background);
}
#app-mount .modeConnected-3IsKId .content-1x5b-n:hover {
    background-color: var(--indicator-connected-hover);
}
#app-mount .modeConnected-3IsKId::before {
    border-left: var(--indicator-border-info) var(--indicator-connected-border);
}
#app-mount .channel-2QD9_O {
    margin-left: 0;
    max-width: 100%;
}
#app-mount .channel-2QD9_O div .avatar-3uk_u9 {
    margin-left: 8px;
}

#app-mount .hljs {
    background: var(--background-secondary);
    color: #a39e9b;
    padding: 15px 20px;
    border-radius: 0;
    border: none;
}
#app-mount .codeLine-14BKbG {
    color: #a39e9b;
}
#app-mount .hljs-comment,
#app-mount .hljs-quote {
    color: #8d8687;
}
#app-mount .hljs-variable,
#app-mount .hljs-template-variable,
#app-mount .hljs-tag,
#app-mount .hljs-name,
#app-mount .hljs-selector-id,
#app-mount .hljs-selector-class,
#app-mount .hljs-selector-pseudo,
#app-mount .hljs-regexp,
#app-mount .hljs-link,
#app-mount .hljs-meta {
    color: #ef6155;
}
#app-mount .hljs-number,
#app-mount .hljs-built_in,
#app-mount .hljs-literal,
#app-mount .hljs-type,
#app-mount .hljs-params,
#app-mount .hljs-deletion {
    color: #f99b15;
}
#app-mount .hljs-title,
#app-mount .hljs-section,
#app-mount .hljs-attribute {
    color: #fec418;
}
#app-mount .hljs-string,
#app-mount .hljs-symbol,
#app-mount .hljs-bullet,
#app-mount .hljs-addition {
    color: #48b685;
}
#app-mount .hljs-keyword,
#app-mount .hljs-selector-tag {
    color: #815ba4;
}
#app-mount .hljs-emphasis {
    font-style: italic;
}
#app-mount .hljs-strong {
    font-weight: bold;
}

.role-2irmRk {
    background-color: var(--background-tertiary);
    border-radius: 4px;
    border: none;
    padding: 0 5px 0 8px;
    height: 25px;
}
.role-2irmRk.actionButton-VzECiy {
    background-color: var(--background-tertiary);
    padding-left: 7px;
    padding-right: 7px;
}
.role-2irmRk .roleCircle-3xAZ1j {
    margin-right: 6px;
    width: 9px;
    height: 9px;
}
